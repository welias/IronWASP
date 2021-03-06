﻿//
// Copyright 2011-2012 Lavakumar Kuppan
//
// This file is part of IronWASP
//
// IronWASP is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3 of the License.
//
// IronWASP is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with IronWASP.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace IronWASP
{
    public class Crawler
    {
        internal List<string> PageSignatures = new List<string>();

        internal List<Request> Requests = new List<Request>();

        internal int MaxDepth = 10;

        Queue<object[]> ToCrawlQueue = new Queue<object[]>();

        Dictionary<int, Thread> CrawlerThreads = new Dictionary<int, Thread>();

        CookieStore Cookies = new CookieStore();

        int ActiveThreadCount = 0;

        internal static int MaxCrawlThreads = 5;

        internal static string UserAgent = "";

        int InCrawlQueueDequeueMode = 0;

        Dictionary<string, Response> NotFoundSignatures = new Dictionary<string, Response>();

        Queue<Request> CrawledRequests = new Queue<Request>();

        List<string> FileNamesToCheck = new List<string>();
        List<string> DirNamesToCheck = new List<string>();

        //Settings
        internal List<string> UrlsToAvoid = new List<string>();
        internal List<string> HostsToInclude = new List<string>();
        internal bool HTTP = false;
        internal bool HTTPS = false;
        internal string StartingUrl = "/";
        internal string BaseUrl = "/";
        internal string PrimaryHost = "";
        internal bool PerformDirAndFileGuessing = true;
        internal bool IncludeSubDomains = false;

        bool Stopped = false;

        public void Start()
        {
            try
            {
                if (HTTP)
                {
                    Request HttpRequest = new Request("http://" + PrimaryHost + StartingUrl);
                    lock (ToCrawlQueue)
                    {
                        ToCrawlQueue.Enqueue(new object[] { HttpRequest, 0, true });
                    }
                }
                if (HTTPS)
                {
                    Request HttpsRequest = new Request("https://" + PrimaryHost + StartingUrl);
                    lock (ToCrawlQueue)
                    {
                        ToCrawlQueue.Enqueue(new object[] { HttpsRequest, 0, true });
                    }
                }
                PageSignatures.Clear();
                if (PerformDirAndFileGuessing) SetUpDirAndFileDictionaries();
                Thread T = new Thread(CrawlQueueItem);
                T.Start();
                try
                {
                    CrawlerThreads.Add(T.ManagedThreadId, T);
                }
                catch { }
            }
            catch (ThreadAbortException){}
            catch (Exception Exp)
            {
                IronException.Report("Error in Crawling", Exp.Message, Exp.StackTrace);
                throw (Exp);
            }
        }

        void SetUpDirAndFileDictionaries()
        {
            try
            {
                StreamReader Reader = File.OpenText(Config.RootDir + "/DirNamesDictionary.txt");
                string DirList = Reader.ReadToEnd();
                Reader.Close();
                DirNamesToCheck = new List<string>(DirList.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            }
            catch(Exception Exp)
            {
                IronException.Report("Error loading DirNamesDictionary.txt", Exp);
            }
            try
            {
                StreamReader Reader = File.OpenText(Config.RootDir + "/FileNamesDictionary.txt");
                string FileList = Reader.ReadToEnd();
                Reader.Close();
                FileNamesToCheck = new List<string>(FileList.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            }
            catch (Exception Exp)
            {
                IronException.Report("Error loading FileNamesDictionary.txt", Exp);
            }
        }

        void Crawl(object ObjectItem)
        {
            if (Stopped) return;
            try
            {
                object[] Objects = (object[])ObjectItem;
                Request Req = (Request)Objects[0];
                int Depth = (int)Objects[1];
                bool Scraped = (bool)Objects[2];
                Crawl(Req, Depth, Scraped);
            }
            catch (ThreadAbortException) { }
            catch (Exception Exp)
            {
                IronException.Report("Error while Crawling", Exp.Message, Exp.StackTrace);
            }
            finally
            {
                CrawlQueueItem();
            }
        }

        void Crawl(Request Req, int Depth, bool Scraped)
        {
            if (Stopped) return;
            if (Depth > MaxDepth) return;
            if (WasCrawled(Req)) return;
            if (!CanCrawl(Req)) return;

            lock (PageSignatures)
            {
                PageSignatures.Add(GetPageSignature(Req));
            }

            Req.Source = RequestSource.Probe;
            Req.SetCookie(Cookies);
            if (UserAgent.Length > 0) Req.Headers.Set("User-Agent", UserAgent);
            Response Res = Req.Send();
            Cookies.Add(Req, Res);
            bool Is404File = IsA404(Req, Res);

            if (!Res.IsHtml)
            {
                return;
            }

            if (Depth + 1 > MaxDepth) return;
            List<Request> LinkClicks = GetLinkClicks(Req, Res);
            foreach (Request LinkClick in LinkClicks)
            {
                AddToCrawlQueue(LinkClick, Depth + 1, true);
            }

            List<Request> FormSubmissions = GetFormSubmissionRequests(Req, Res);
            foreach (Request FormSubmission in FormSubmissions)
            {
                AddToCrawlQueue(FormSubmission, Depth + 1, true);
            }

            Request DirCheck = Req.GetClone();
            DirCheck.Method = "GET";
            DirCheck.Body.RemoveAll();
            DirCheck.Url = DirCheck.UrlDir;

            if (!Req.Url.EndsWith("/"))
            {
                AddToCrawlQueue(DirCheck, Depth + 1, false);
            }

            if (PerformDirAndFileGuessing && !Is404File)
            {
                foreach (string File in FileNamesToCheck)
                {
                    Request FileCheck = DirCheck.GetClone();
                    FileCheck.Url = FileCheck.Url + File;
                    AddToCrawlQueue(FileCheck, Depth + 1, false);
                }

                foreach (string Dir in DirNamesToCheck)
                {
                    Request DirectoryCheck = DirCheck.GetClone();
                    DirectoryCheck.Url = DirectoryCheck.Url + Dir + "/";
                    AddToCrawlQueue(DirectoryCheck, Depth + 1, false);
                }
            }

            if (Scraped || !Is404File)
            {
                lock (CrawledRequests)
                {
                    CrawledRequests.Enqueue(Req);
                }
                IronUpdater.AddToSiteMap(Req);
            }
        }

        void CrawlQueueItem()
        {
            if (Stopped) return;
            try
            {
                Interlocked.Increment(ref InCrawlQueueDequeueMode);
                bool Continue = true;
                Interlocked.Decrement(ref ActiveThreadCount);
                lock (ToCrawlQueue)
                {
                    while (ActiveThreadCount < MaxCrawlThreads && Continue)
                    {
                        Continue = false;
                        try
                        {
                            object[] Objects = ToCrawlQueue.Dequeue();
                            Thread T = new Thread(Crawl);
                            T.Start(Objects);
                            try
                            {
                                lock (CrawlerThreads)
                                {
                                    CrawlerThreads.Add(T.ManagedThreadId, T);
                                }
                            }
                            catch { }
                            Interlocked.Increment(ref ActiveThreadCount);
                            Continue = true;
                        }
                        catch { }
                    }
                }                
            }
            catch { }
            try
            {
                lock (CrawlerThreads)
                {
                    CrawlerThreads.Remove(Thread.CurrentThread.ManagedThreadId);
                }
            }
            catch { }
            Interlocked.Decrement(ref InCrawlQueueDequeueMode);
        }

        bool WasCrawled(Request Req)
        {
            string ReqSignature = GetPageSignature(Req);
            lock(PageSignatures)
            {
                if (PageSignatures.Contains(ReqSignature))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        bool CanCrawl(Request Req)
        {
            if (!((Req.SSL && HTTPS) || (!Req.SSL && HTTP))) return false;
            if(!IsHostAllowed(Req.Host)) return false;
            if (!Req.Url.Equals(BaseUrl))
            {
                if (BaseUrl.EndsWith("/"))
                {
                    if (!Req.Url.StartsWith(BaseUrl)) return false;
                }
                else
                {
                    if (!Req.Url.StartsWith(BaseUrl + "?")) return false;
                }
            }
            if (UrlsToAvoid.Contains(Req.Url) || UrlsToAvoid.Contains(Req.UrlPath)) return false;
            return true;
        }

        bool IsHostAllowed(string Host)
        {
            if(Host.Equals(PrimaryHost)) return true;
            if(IncludeSubDomains && Host.EndsWith("." + PrimaryHost)) return true;
            foreach(string AH in HostsToInclude)
            {
                if(Host.Equals(AH)) return true;
                if(IncludeSubDomains && Host.EndsWith("." + AH)) return true;
            }
            return false;
        }

        bool IsA404(Request Req, Response Res)
        {
            Response NotFoundResponse = null;
            lock (NotFoundSignatures)
            {
                if (NotFoundSignatures.ContainsKey(Req.SSL.ToString() + Req.Host + Req.UrlDir + Req.File))
                {
                    NotFoundResponse = NotFoundSignatures[Req.SSL.ToString() + Req.Host + Req.UrlDir + Req.File];
                }
            }
            if(NotFoundResponse == null)
            {
                Request NotFoundGetter = Req.GetClone();
                NotFoundGetter.Method = "GET";
                NotFoundGetter.Body.RemoveAll();
                if (Req.File.Length > 0)
                    NotFoundGetter.Url = NotFoundGetter.UrlDir + "should_not_xist_" + Tools.GetRandomString(10, 15) + "." + Req.File;
                else
                    NotFoundGetter.Url = NotFoundGetter.UrlDir + "should_not_xist_" + Tools.GetRandomString(10, 15);
                NotFoundResponse = NotFoundGetter.Send();
                NotFoundResponse.Flags.Add("Url", NotFoundGetter.Url);
                lock (NotFoundSignatures)
                {
                    if (!NotFoundSignatures.ContainsKey(Req.SSL.ToString() + Req.Host + Req.UrlDir + Req.File))
                        NotFoundSignatures.Add(Req.SSL.ToString() + Req.Host + Req.UrlDir + Req.File, NotFoundResponse);
                }
            }
            if(Res.Code == 200 && NotFoundResponse.Code != 200) return false;
            if(Res.Code == 404) return true;
            
            if (Res.Code > 400)
            {
                if (NotFoundResponse.Code == Res.Code) 
                    return true;
                else
                    return false;
            }
            string NotFoundGetterUrl = NotFoundResponse.Flags["Url"].ToString();
            if (Res.Code == 301 || Res.Code == 302 || Res.Code == 303 || Res.Code == 307)
            {
                string RedirectedUrl = Res.Headers.Get("Location");
                if (NotFoundResponse.Code == 301 || NotFoundResponse.Code == 302 || NotFoundResponse.Code == 303 || NotFoundResponse.Code == 307)
                {
                    string NotFoundRedirectedUrl = NotFoundResponse.Headers.Get("Location");
                    if (RedirectedUrl.ToLower().Equals(NotFoundRedirectedUrl.ToLower()))
                        return true;
                    else if (Regex.IsMatch(RedirectedUrl, @".*not\Wfound.*", RegexOptions.IgnoreCase))
                        return true;
                    else if (NotFoundRedirectedUrl.Replace(NotFoundGetterUrl,"").Equals(RedirectedUrl.Replace(Req.Url, "")))
                        return true;
                    else
                    {
                        Request RedirectedLocationReq;
                        if (RedirectedUrl.StartsWith("http://") || RedirectedUrl.StartsWith("https://"))
                        {
                            RedirectedLocationReq = new Request(RedirectedUrl);
                        }
                        else if (RedirectedUrl.StartsWith("/"))
                        {
                            RedirectedLocationReq = Req.GetClone();
                            RedirectedLocationReq.Url = RedirectedUrl;
                        }
                        else
                        {
                            return true;
                        }
                        Request NotFoundRedirectedLocationReq;
                        if (NotFoundRedirectedUrl.StartsWith("http://") || NotFoundRedirectedUrl.StartsWith("https://"))
                        {
                            NotFoundRedirectedLocationReq = new Request(NotFoundRedirectedUrl);
                        }
                        else if (NotFoundRedirectedUrl.StartsWith("/"))
                        {
                            NotFoundRedirectedLocationReq = Req.GetClone();
                            NotFoundRedirectedLocationReq.Url = NotFoundRedirectedUrl;
                        }
                        else
                        {
                            return false;
                        }
                        if (RedirectedLocationReq.Url.Equals(NotFoundRedirectedLocationReq.Url)) return true;
                    }
                }
                else
                    return false;
            }
            return false;
        }

        internal bool IsActive()
        {
            lock (ToCrawlQueue)
            {
                if (ToCrawlQueue.Count > 0) return true;
            }
            if (ActiveThreadCount > 0 || InCrawlQueueDequeueMode > 0)
                return true;
            else
                return false;
        }

        void AddToCrawlQueue(Request Req, int Depth, bool Scraped)
        {
            if (WasCrawled(Req)) return;
            if (!CanCrawl(Req)) return;
            lock (ToCrawlQueue)
            {
                ToCrawlQueue.Enqueue(new object[] { Req, Depth, Scraped });
            }
        }

        List<Request> GetLinkClicks(Request Req, Response Res)
        {
            List<Request> LinkClicks = new List<Request>();
            List<string> Links = GetLinks(Req, Res);
            foreach (string Link in Links)
            {
                try
                {
                    Request LinkReq = new Request(Link);
                    LinkReq.SetCookie(Cookies);
                    LinkClicks.Add(LinkReq);
                }
                catch { }
            }
            return LinkClicks;
        }

        List<Request> GetFormSubmissionRequests(Request Req, Response Res)
        {
            List<Request> FormSubmissions = new List<Request>();
            List<HtmlNode> FormNodes = Res.Html.GetForms();
            foreach (HtmlNode FormNode in FormNodes)
            {
                Request SubReq = Req.GetClone();
                SubReq.Method = "GET";
                SubReq.BodyString = "";

                foreach (HtmlAttribute Attr in FormNode.Attributes)
                {
                    if (Attr.Name.Equals("method"))
                    {
                        SubReq.Method = Attr.Value.ToUpper();
                    }
                    else if(Attr.Name.Equals("action"))
                    {
                        if (Attr.Value.StartsWith("javascript:")) continue;
                        string ActionUrl = NormalizeUrl(Req, Attr.Value.Trim());
                        if (ActionUrl.Length > 0)
                        {
                            SubReq.FullUrl = ActionUrl;
                        }
                    }
                }

                if (SubReq.Method == "GET")
                {
                    SubReq.Query.RemoveAll();
                }
                else
                {
                    SubReq.Headers.Set("Content-Type", "application/x-www-form-urlencoded");
                }

                foreach (HtmlNode InputNode in FormNode.ChildNodes)
                {
                    string Name = "";
                    string Value = "";
                    foreach (HtmlAttribute Attr in InputNode.Attributes)
                    {
                        switch(Attr.Name)
                        {
                            case("name"):
                                Name = Attr.Value;
                                break;
                            case("type"):
                                if(Attr.Value.Equals("submit")) Name = "";
                                break;
                            case("value"):
                                Value = Attr.Value;
                                break;
                        }
                    }
                    if (Value.Length == 0)
                    {
                        Value = Tools.GetRandomString(2,5);
                    }
                    if (Name.Length > 0)
                    {
                        if (SubReq.Method.Equals("GET"))
                            SubReq.Query.Add(Name, Value);
                        else
                            SubReq.Body.Add(Name, Value);
                    }
                }
                FormSubmissions.Add(SubReq);
            }
            return FormSubmissions;
        }

        List<string> GetLinks(Request Req, Response Res)
        {
            List<string> Links = new List<string>();
            foreach (string Link in Res.Html.Links)
            {
                string NormalizedUrl = NormalizeUrl(Req, Link);
                if (NormalizedUrl.Length > 0) Links.Add(NormalizedUrl);
            }
            return Links;
        }

        string NormalizeUrl(Request Req, string RawLink)
        {
            if (RawLink.IndexOf('#') > -1)
            {
                RawLink = RawLink.Substring(0, RawLink.IndexOf('#'));
            }
            if (RawLink.StartsWith("http://") || RawLink.StartsWith("https://"))
            {
                return RawLink;
            }
            else if (RawLink.StartsWith("//"))
            {
                if (Req.SSL)
                    RawLink = "https:" + RawLink;
                else
                    RawLink = "http:" + RawLink;
            }
            else if (RawLink.StartsWith("/"))
            {
                Request TempReq = Req.GetClone();
                TempReq.Url = RawLink;
                return TempReq.FullUrl;
            }
            else if (RawLink.StartsWith("javascript:") || RawLink.StartsWith("file:"))
            {
                //ignore
            }
            else
            {
                List<string> UrlPathParts = Req.UrlPathParts;
                if (UrlPathParts.Count > 0)
                {
                    if (!Req.Url.EndsWith("/")) UrlPathParts.RemoveAt(UrlPathParts.Count - 1);
                }

                if (RawLink.StartsWith("../"))
                {
                    string[] RawUrlParts = RawLink.Split(new char[] { '/' });
                    List<string> TreatedRawUrlParts = new List<string>(RawUrlParts);
                    foreach (string Part in RawUrlParts)
                    {
                        if (Part.Equals("..") && (UrlPathParts.Count > 0))
                        {
                            UrlPathParts.RemoveAt(UrlPathParts.Count - 1);
                            TreatedRawUrlParts.RemoveAt(0);
                        }
                        else
                        {
                            break;
                        }
                    }
                    StringBuilder TreatedRawUrlBuilder = new StringBuilder("/");
                    foreach (string RawPart in TreatedRawUrlParts)
                    {
                        TreatedRawUrlBuilder.Append(RawPart);
                    }
                    string TreatedRawUrl = TreatedRawUrlBuilder.ToString();
                    if (!RawLink.EndsWith("/"))
                    {
                        TreatedRawUrl = TreatedRawUrl.TrimEnd(new char[] { '/' });
                    }
                    Request TempReq = Req.GetClone();
                    Request NormaliserRequest = new Request(TempReq.FullUrl);
                    NormaliserRequest.Url = "/";
                    NormaliserRequest.UrlPathParts = UrlPathParts;
                    TempReq.Url = NormaliserRequest.Url;
                    TempReq.Url = TempReq.Url.TrimEnd(new char[] { '/' }) + TreatedRawUrl;
                    return TempReq.FullUrl;
                }
                else if (RawLink.Length > 0)
                {
                    Request TempReq = Req.GetClone();
                    Request NormaliserRequest = new Request(TempReq.FullUrl);
                    NormaliserRequest.Url = "/";
                    NormaliserRequest.UrlPathParts = UrlPathParts;
                    TempReq.Url = NormaliserRequest.Url;

                    if (TempReq.Url.EndsWith("/"))
                    {
                        TempReq.Url = TempReq.Url + RawLink;
                    }
                    else
                    {
                        TempReq.Url = TempReq.Url + "/" + RawLink;
                    }
                    return TempReq.FullURL;
                }
            }
            return "";
        }

        string GetPageSignature(Request Req)
        {
            StringBuilder Signature = new StringBuilder();
            Signature.Append(Req.SSL.ToString());
            Signature.Append(Req.Host);
            Signature.Append(Req.Method);
            Signature.Append(Req.Url);
            Signature.Append(Req.BodyString);
            Signature.Append(Req.CookieString);
            return Tools.MD5(Signature.ToString());
        }

        public List<Request> GetCrawledRequests()
        {
            List<Request> Requests = new List<Request>();
            lock (CrawledRequests)
            {
                Requests = new List<Request>(CrawledRequests.ToArray());
                CrawledRequests.Clear();
            }
            return Requests;
        }

        public void Stop()
        {
            Stopped = true;
            lock (CrawlerThreads)
            {
                List<int> IDs = new List<int>(CrawlerThreads.Keys);
                foreach (int ID in IDs)
                {
                    try
                    {
                        CrawlerThreads[ID].Abort();
                        CrawlerThreads.Remove(ID);
                    }
                    catch { }
                }
            }
        }
    }
}
