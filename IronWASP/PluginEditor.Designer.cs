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

namespace IronWASP
{
    partial class PluginEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginEditor));
            this.PluginEditorBaseSplit = new System.Windows.Forms.SplitContainer();
            this.PluginEditorRightSplit = new System.Windows.Forms.SplitContainer();
            this.PluginEditorTE = new ICSharpCode.TextEditor.TextEditorControl();
            this.PluginEditorErrorTB = new System.Windows.Forms.TextBox();
            this.PluginEditorMenu = new System.Windows.Forms.MenuStrip();
            this.NewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewActivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPyActivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRbActivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPassivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPyPassivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRbPassivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSessionPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPySessionPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRbSessionPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFormatPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPyFormatPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRbFormatPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewScriptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPyScriptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRbScriptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passivePluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatPluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionPluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IronPythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IronRubyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckSyntaxF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PluginEditorAPISplit = new System.Windows.Forms.SplitContainer();
            this.PluginEditorAPITreeTabs = new System.Windows.Forms.TabControl();
            this.PluginEditorPythonAPITreeTab = new System.Windows.Forms.TabPage();
            this.PluginEditorPythonAPITree = new System.Windows.Forms.TreeView();
            this.PluginEditorRubyAPITreeTab = new System.Windows.Forms.TabPage();
            this.PluginEditorRubyAPITree = new System.Windows.Forms.TreeView();
            this.PluginEditorAPIDetailsRTB = new System.Windows.Forms.RichTextBox();
            this.PluginEditorAPIDocTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PluginEditorOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PluginEditorSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PluginEditorBaseSplit.Panel1.SuspendLayout();
            this.PluginEditorBaseSplit.Panel2.SuspendLayout();
            this.PluginEditorBaseSplit.SuspendLayout();
            this.PluginEditorRightSplit.Panel1.SuspendLayout();
            this.PluginEditorRightSplit.Panel2.SuspendLayout();
            this.PluginEditorRightSplit.SuspendLayout();
            this.PluginEditorMenu.SuspendLayout();
            this.PluginEditorAPISplit.Panel1.SuspendLayout();
            this.PluginEditorAPISplit.Panel2.SuspendLayout();
            this.PluginEditorAPISplit.SuspendLayout();
            this.PluginEditorAPITreeTabs.SuspendLayout();
            this.PluginEditorPythonAPITreeTab.SuspendLayout();
            this.PluginEditorRubyAPITreeTab.SuspendLayout();
            this.PluginEditorAPIDocTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // PluginEditorBaseSplit
            // 
            this.PluginEditorBaseSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorBaseSplit.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorBaseSplit.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorBaseSplit.Name = "PluginEditorBaseSplit";
            // 
            // PluginEditorBaseSplit.Panel1
            // 
            this.PluginEditorBaseSplit.Panel1.Controls.Add(this.PluginEditorRightSplit);
            this.PluginEditorBaseSplit.Panel1.Controls.Add(this.PluginEditorMenu);
            // 
            // PluginEditorBaseSplit.Panel2
            // 
            this.PluginEditorBaseSplit.Panel2.Controls.Add(this.PluginEditorAPISplit);
            this.PluginEditorBaseSplit.Size = new System.Drawing.Size(684, 462);
            this.PluginEditorBaseSplit.SplitterDistance = 453;
            this.PluginEditorBaseSplit.SplitterWidth = 2;
            this.PluginEditorBaseSplit.TabIndex = 0;
            // 
            // PluginEditorRightSplit
            // 
            this.PluginEditorRightSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorRightSplit.Location = new System.Drawing.Point(0, 24);
            this.PluginEditorRightSplit.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorRightSplit.Name = "PluginEditorRightSplit";
            this.PluginEditorRightSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PluginEditorRightSplit.Panel1
            // 
            this.PluginEditorRightSplit.Panel1.Controls.Add(this.PluginEditorTE);
            // 
            // PluginEditorRightSplit.Panel2
            // 
            this.PluginEditorRightSplit.Panel2.Controls.Add(this.PluginEditorErrorTB);
            this.PluginEditorRightSplit.Size = new System.Drawing.Size(453, 438);
            this.PluginEditorRightSplit.SplitterDistance = 343;
            this.PluginEditorRightSplit.SplitterWidth = 2;
            this.PluginEditorRightSplit.TabIndex = 5;
            // 
            // PluginEditorTE
            // 
            this.PluginEditorTE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorTE.IsIconBarVisible = false;
            this.PluginEditorTE.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorTE.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorTE.Name = "PluginEditorTE";
            this.PluginEditorTE.ShowEOLMarkers = true;
            this.PluginEditorTE.ShowSpaces = true;
            this.PluginEditorTE.ShowTabs = true;
            this.PluginEditorTE.ShowVRuler = true;
            this.PluginEditorTE.Size = new System.Drawing.Size(453, 343);
            this.PluginEditorTE.TabIndex = 3;
            // 
            // PluginEditorErrorTB
            // 
            this.PluginEditorErrorTB.BackColor = System.Drawing.Color.White;
            this.PluginEditorErrorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PluginEditorErrorTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorErrorTB.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorErrorTB.Multiline = true;
            this.PluginEditorErrorTB.Name = "PluginEditorErrorTB";
            this.PluginEditorErrorTB.ReadOnly = true;
            this.PluginEditorErrorTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PluginEditorErrorTB.Size = new System.Drawing.Size(453, 93);
            this.PluginEditorErrorTB.TabIndex = 4;
            // 
            // PluginEditorMenu
            // 
            this.PluginEditorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.SaveWorkToolStripMenuItem,
            this.LanguageToolStripMenuItem,
            this.CheckSyntaxF5ToolStripMenuItem});
            this.PluginEditorMenu.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorMenu.Name = "PluginEditorMenu";
            this.PluginEditorMenu.Size = new System.Drawing.Size(453, 24);
            this.PluginEditorMenu.TabIndex = 2;
            this.PluginEditorMenu.Text = "menuStrip1";
            // 
            // NewFileToolStripMenuItem
            // 
            this.NewFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewActivePluginToolStripMenuItem,
            this.NewPassivePluginToolStripMenuItem,
            this.NewSessionPluginToolStripMenuItem,
            this.NewFormatPluginToolStripMenuItem,
            this.NewScriptFileToolStripMenuItem});
            this.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem";
            this.NewFileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.NewFileToolStripMenuItem.Text = "New";
            // 
            // NewActivePluginToolStripMenuItem
            // 
            this.NewActivePluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPyActivePluginToolStripMenuItem,
            this.NewRbActivePluginToolStripMenuItem});
            this.NewActivePluginToolStripMenuItem.Name = "NewActivePluginToolStripMenuItem";
            this.NewActivePluginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.NewActivePluginToolStripMenuItem.Text = "Active Plugin";
            // 
            // NewPyActivePluginToolStripMenuItem
            // 
            this.NewPyActivePluginToolStripMenuItem.Name = "NewPyActivePluginToolStripMenuItem";
            this.NewPyActivePluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewPyActivePluginToolStripMenuItem.Text = "Python";
            this.NewPyActivePluginToolStripMenuItem.Click += new System.EventHandler(this.NewPyActivePluginToolStripMenuItem_Click);
            // 
            // NewRbActivePluginToolStripMenuItem
            // 
            this.NewRbActivePluginToolStripMenuItem.Name = "NewRbActivePluginToolStripMenuItem";
            this.NewRbActivePluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewRbActivePluginToolStripMenuItem.Text = "Ruby";
            this.NewRbActivePluginToolStripMenuItem.Click += new System.EventHandler(this.NewRbActivePluginToolStripMenuItem_Click);
            // 
            // NewPassivePluginToolStripMenuItem
            // 
            this.NewPassivePluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPyPassivePluginToolStripMenuItem,
            this.NewRbPassivePluginToolStripMenuItem});
            this.NewPassivePluginToolStripMenuItem.Name = "NewPassivePluginToolStripMenuItem";
            this.NewPassivePluginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.NewPassivePluginToolStripMenuItem.Text = "Passive Plugin";
            // 
            // NewPyPassivePluginToolStripMenuItem
            // 
            this.NewPyPassivePluginToolStripMenuItem.Name = "NewPyPassivePluginToolStripMenuItem";
            this.NewPyPassivePluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewPyPassivePluginToolStripMenuItem.Text = "Python";
            this.NewPyPassivePluginToolStripMenuItem.Click += new System.EventHandler(this.NewPyPassivePluginToolStripMenuItem_Click);
            // 
            // NewRbPassivePluginToolStripMenuItem
            // 
            this.NewRbPassivePluginToolStripMenuItem.Name = "NewRbPassivePluginToolStripMenuItem";
            this.NewRbPassivePluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewRbPassivePluginToolStripMenuItem.Text = "Ruby";
            this.NewRbPassivePluginToolStripMenuItem.Click += new System.EventHandler(this.NewRbPassivePluginToolStripMenuItem_Click);
            // 
            // NewSessionPluginToolStripMenuItem
            // 
            this.NewSessionPluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPySessionPluginToolStripMenuItem,
            this.NewRbSessionPluginToolStripMenuItem});
            this.NewSessionPluginToolStripMenuItem.Name = "NewSessionPluginToolStripMenuItem";
            this.NewSessionPluginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.NewSessionPluginToolStripMenuItem.Text = "Session Plugin";
            // 
            // NewPySessionPluginToolStripMenuItem
            // 
            this.NewPySessionPluginToolStripMenuItem.Name = "NewPySessionPluginToolStripMenuItem";
            this.NewPySessionPluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewPySessionPluginToolStripMenuItem.Text = "Python";
            this.NewPySessionPluginToolStripMenuItem.Click += new System.EventHandler(this.NewPySessionPluginToolStripMenuItem_Click);
            // 
            // NewRbSessionPluginToolStripMenuItem
            // 
            this.NewRbSessionPluginToolStripMenuItem.Name = "NewRbSessionPluginToolStripMenuItem";
            this.NewRbSessionPluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewRbSessionPluginToolStripMenuItem.Text = "Ruby";
            this.NewRbSessionPluginToolStripMenuItem.Click += new System.EventHandler(this.NewRbSessionPluginToolStripMenuItem_Click);
            // 
            // NewFormatPluginToolStripMenuItem
            // 
            this.NewFormatPluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPyFormatPluginToolStripMenuItem,
            this.NewRbFormatPluginToolStripMenuItem});
            this.NewFormatPluginToolStripMenuItem.Name = "NewFormatPluginToolStripMenuItem";
            this.NewFormatPluginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.NewFormatPluginToolStripMenuItem.Text = "Format Plugin";
            // 
            // NewPyFormatPluginToolStripMenuItem
            // 
            this.NewPyFormatPluginToolStripMenuItem.Name = "NewPyFormatPluginToolStripMenuItem";
            this.NewPyFormatPluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewPyFormatPluginToolStripMenuItem.Text = "Python";
            this.NewPyFormatPluginToolStripMenuItem.Click += new System.EventHandler(this.NewPyFormatPluginToolStripMenuItem_Click);
            // 
            // NewRbFormatPluginToolStripMenuItem
            // 
            this.NewRbFormatPluginToolStripMenuItem.Name = "NewRbFormatPluginToolStripMenuItem";
            this.NewRbFormatPluginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewRbFormatPluginToolStripMenuItem.Text = "Ruby";
            this.NewRbFormatPluginToolStripMenuItem.Click += new System.EventHandler(this.NewRbFormatPluginToolStripMenuItem_Click);
            // 
            // NewScriptFileToolStripMenuItem
            // 
            this.NewScriptFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPyScriptFileToolStripMenuItem,
            this.NewRbScriptFileToolStripMenuItem});
            this.NewScriptFileToolStripMenuItem.Name = "NewScriptFileToolStripMenuItem";
            this.NewScriptFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.NewScriptFileToolStripMenuItem.Text = "Script";
            // 
            // NewPyScriptFileToolStripMenuItem
            // 
            this.NewPyScriptFileToolStripMenuItem.Name = "NewPyScriptFileToolStripMenuItem";
            this.NewPyScriptFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewPyScriptFileToolStripMenuItem.Text = "Python";
            this.NewPyScriptFileToolStripMenuItem.Click += new System.EventHandler(this.NewPyScriptFileToolStripMenuItem_Click);
            // 
            // NewRbScriptFileToolStripMenuItem
            // 
            this.NewRbScriptFileToolStripMenuItem.Name = "NewRbScriptFileToolStripMenuItem";
            this.NewRbScriptFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewRbScriptFileToolStripMenuItem.Text = "Ruby";
            this.NewRbScriptFileToolStripMenuItem.Click += new System.EventHandler(this.NewRbScriptFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActivePluginToolStripMenuItem,
            this.passivePluginToolStripMenuItem1,
            this.formatPluginToolStripMenuItem1,
            this.sessionPluginToolStripMenuItem1,
            this.otherToolStripMenuItem});
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.saveToolStripMenuItem1.Text = "Open File";
            // 
            // ActivePluginToolStripMenuItem
            // 
            this.ActivePluginToolStripMenuItem.Name = "ActivePluginToolStripMenuItem";
            this.ActivePluginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ActivePluginToolStripMenuItem.Text = "Active Plugin";
            this.ActivePluginToolStripMenuItem.Click += new System.EventHandler(this.ActivePluginToolStripMenuItem_Click);
            // 
            // passivePluginToolStripMenuItem1
            // 
            this.passivePluginToolStripMenuItem1.Name = "passivePluginToolStripMenuItem1";
            this.passivePluginToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.passivePluginToolStripMenuItem1.Text = "Passive Plugin";
            this.passivePluginToolStripMenuItem1.Click += new System.EventHandler(this.passivePluginToolStripMenuItem1_Click);
            // 
            // formatPluginToolStripMenuItem1
            // 
            this.formatPluginToolStripMenuItem1.Name = "formatPluginToolStripMenuItem1";
            this.formatPluginToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.formatPluginToolStripMenuItem1.Text = "Format Plugin";
            this.formatPluginToolStripMenuItem1.Click += new System.EventHandler(this.formatPluginToolStripMenuItem1_Click);
            // 
            // sessionPluginToolStripMenuItem1
            // 
            this.sessionPluginToolStripMenuItem1.Name = "sessionPluginToolStripMenuItem1";
            this.sessionPluginToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.sessionPluginToolStripMenuItem1.Text = "Session Plugin";
            this.sessionPluginToolStripMenuItem1.Click += new System.EventHandler(this.sessionPluginToolStripMenuItem1_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // SaveWorkToolStripMenuItem
            // 
            this.SaveWorkToolStripMenuItem.Name = "SaveWorkToolStripMenuItem";
            this.SaveWorkToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.SaveWorkToolStripMenuItem.Text = "Save Work";
            this.SaveWorkToolStripMenuItem.Click += new System.EventHandler(this.SaveWorkToolStripMenuItem_Click);
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IronPythonToolStripMenuItem,
            this.IronRubyToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.LanguageToolStripMenuItem.Text = "Set Language";
            // 
            // IronPythonToolStripMenuItem
            // 
            this.IronPythonToolStripMenuItem.Name = "IronPythonToolStripMenuItem";
            this.IronPythonToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.IronPythonToolStripMenuItem.Text = "IronPython";
            this.IronPythonToolStripMenuItem.Click += new System.EventHandler(this.IronPythonToolStripMenuItem_Click);
            // 
            // IronRubyToolStripMenuItem
            // 
            this.IronRubyToolStripMenuItem.Name = "IronRubyToolStripMenuItem";
            this.IronRubyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.IronRubyToolStripMenuItem.Text = "IronRuby";
            this.IronRubyToolStripMenuItem.Click += new System.EventHandler(this.IronRubyToolStripMenuItem_Click);
            // 
            // CheckSyntaxF5ToolStripMenuItem
            // 
            this.CheckSyntaxF5ToolStripMenuItem.Name = "CheckSyntaxF5ToolStripMenuItem";
            this.CheckSyntaxF5ToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.CheckSyntaxF5ToolStripMenuItem.Text = "Check Syntax - F5";
            this.CheckSyntaxF5ToolStripMenuItem.Click += new System.EventHandler(this.CheckSyntaxF5ToolStripMenuItem_Click);
            // 
            // PluginEditorAPISplit
            // 
            this.PluginEditorAPISplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorAPISplit.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorAPISplit.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorAPISplit.Name = "PluginEditorAPISplit";
            this.PluginEditorAPISplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PluginEditorAPISplit.Panel1
            // 
            this.PluginEditorAPISplit.Panel1.Controls.Add(this.PluginEditorAPITreeTabs);
            // 
            // PluginEditorAPISplit.Panel2
            // 
            this.PluginEditorAPISplit.Panel2.Controls.Add(this.PluginEditorAPIDetailsRTB);
            this.PluginEditorAPISplit.Size = new System.Drawing.Size(229, 462);
            this.PluginEditorAPISplit.SplitterDistance = 251;
            this.PluginEditorAPISplit.SplitterWidth = 2;
            this.PluginEditorAPISplit.TabIndex = 2;
            // 
            // PluginEditorAPITreeTabs
            // 
            this.PluginEditorAPITreeTabs.Controls.Add(this.PluginEditorPythonAPITreeTab);
            this.PluginEditorAPITreeTabs.Controls.Add(this.PluginEditorRubyAPITreeTab);
            this.PluginEditorAPITreeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorAPITreeTabs.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorAPITreeTabs.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorAPITreeTabs.Name = "PluginEditorAPITreeTabs";
            this.PluginEditorAPITreeTabs.Padding = new System.Drawing.Point(0, 0);
            this.PluginEditorAPITreeTabs.SelectedIndex = 0;
            this.PluginEditorAPITreeTabs.Size = new System.Drawing.Size(229, 251);
            this.PluginEditorAPITreeTabs.TabIndex = 0;
            // 
            // PluginEditorPythonAPITreeTab
            // 
            this.PluginEditorPythonAPITreeTab.Controls.Add(this.PluginEditorPythonAPITree);
            this.PluginEditorPythonAPITreeTab.Location = new System.Drawing.Point(4, 22);
            this.PluginEditorPythonAPITreeTab.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorPythonAPITreeTab.Name = "PluginEditorPythonAPITreeTab";
            this.PluginEditorPythonAPITreeTab.Size = new System.Drawing.Size(221, 225);
            this.PluginEditorPythonAPITreeTab.TabIndex = 0;
            this.PluginEditorPythonAPITreeTab.Text = "Python";
            this.PluginEditorPythonAPITreeTab.UseVisualStyleBackColor = true;
            // 
            // PluginEditorPythonAPITree
            // 
            this.PluginEditorPythonAPITree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PluginEditorPythonAPITree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorPythonAPITree.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorPythonAPITree.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorPythonAPITree.Name = "PluginEditorPythonAPITree";
            this.PluginEditorPythonAPITree.Size = new System.Drawing.Size(221, 225);
            this.PluginEditorPythonAPITree.TabIndex = 0;
            this.PluginEditorPythonAPITree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PluginEditorPythonAPITree_AfterSelect);
            // 
            // PluginEditorRubyAPITreeTab
            // 
            this.PluginEditorRubyAPITreeTab.Controls.Add(this.PluginEditorRubyAPITree);
            this.PluginEditorRubyAPITreeTab.Location = new System.Drawing.Point(4, 22);
            this.PluginEditorRubyAPITreeTab.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorRubyAPITreeTab.Name = "PluginEditorRubyAPITreeTab";
            this.PluginEditorRubyAPITreeTab.Size = new System.Drawing.Size(221, 225);
            this.PluginEditorRubyAPITreeTab.TabIndex = 1;
            this.PluginEditorRubyAPITreeTab.Text = "Ruby";
            this.PluginEditorRubyAPITreeTab.UseVisualStyleBackColor = true;
            // 
            // PluginEditorRubyAPITree
            // 
            this.PluginEditorRubyAPITree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PluginEditorRubyAPITree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorRubyAPITree.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorRubyAPITree.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorRubyAPITree.Name = "PluginEditorRubyAPITree";
            this.PluginEditorRubyAPITree.Size = new System.Drawing.Size(221, 225);
            this.PluginEditorRubyAPITree.TabIndex = 1;
            this.PluginEditorRubyAPITree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PluginEditorRubyAPITree_AfterSelect);
            // 
            // PluginEditorAPIDetailsRTB
            // 
            this.PluginEditorAPIDetailsRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorAPIDetailsRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginEditorAPIDetailsRTB.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorAPIDetailsRTB.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorAPIDetailsRTB.Name = "PluginEditorAPIDetailsRTB";
            this.PluginEditorAPIDetailsRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PluginEditorAPIDetailsRTB.Size = new System.Drawing.Size(229, 209);
            this.PluginEditorAPIDetailsRTB.TabIndex = 0;
            this.PluginEditorAPIDetailsRTB.Text = "";
            // 
            // PluginEditorAPIDocTabs
            // 
            this.PluginEditorAPIDocTabs.Controls.Add(this.tabPage3);
            this.PluginEditorAPIDocTabs.Controls.Add(this.tabPage4);
            this.PluginEditorAPIDocTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginEditorAPIDocTabs.Location = new System.Drawing.Point(0, 0);
            this.PluginEditorAPIDocTabs.Margin = new System.Windows.Forms.Padding(0);
            this.PluginEditorAPIDocTabs.Name = "PluginEditorAPIDocTabs";
            this.PluginEditorAPIDocTabs.Padding = new System.Drawing.Point(0, 0);
            this.PluginEditorAPIDocTabs.SelectedIndex = 0;
            this.PluginEditorAPIDocTabs.Size = new System.Drawing.Size(183, 210);
            this.PluginEditorAPIDocTabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(175, 184);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "IronPython";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(175, 184);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "IronRuby";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PluginEditorOpenFileDialog
            // 
            this.PluginEditorOpenFileDialog.Filter = "Python|*.py|Ruby|*.rb|All Files|*.*";
            this.PluginEditorOpenFileDialog.FilterIndex = 3;
            // 
            // PluginEditorSaveFileDialog
            // 
            this.PluginEditorSaveFileDialog.Title = "Save File";
            // 
            // PluginEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.PluginEditorBaseSplit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginEditor";
            this.Text = "Script/Plugin Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginEditor_FormClosing);
            this.Load += new System.EventHandler(this.PluginEditor_Load);
            this.PluginEditorBaseSplit.Panel1.ResumeLayout(false);
            this.PluginEditorBaseSplit.Panel1.PerformLayout();
            this.PluginEditorBaseSplit.Panel2.ResumeLayout(false);
            this.PluginEditorBaseSplit.ResumeLayout(false);
            this.PluginEditorRightSplit.Panel1.ResumeLayout(false);
            this.PluginEditorRightSplit.Panel2.ResumeLayout(false);
            this.PluginEditorRightSplit.Panel2.PerformLayout();
            this.PluginEditorRightSplit.ResumeLayout(false);
            this.PluginEditorMenu.ResumeLayout(false);
            this.PluginEditorMenu.PerformLayout();
            this.PluginEditorAPISplit.Panel1.ResumeLayout(false);
            this.PluginEditorAPISplit.Panel2.ResumeLayout(false);
            this.PluginEditorAPISplit.ResumeLayout(false);
            this.PluginEditorAPITreeTabs.ResumeLayout(false);
            this.PluginEditorPythonAPITreeTab.ResumeLayout(false);
            this.PluginEditorRubyAPITreeTab.ResumeLayout(false);
            this.PluginEditorAPIDocTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer PluginEditorBaseSplit;
        private ICSharpCode.TextEditor.TextEditorControl PluginEditorTE;
        private System.Windows.Forms.MenuStrip PluginEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem NewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewActivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPassivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSessionPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFormatPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewScriptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IronPythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IronRubyToolStripMenuItem;
        private System.Windows.Forms.TabControl PluginEditorAPIDocTabs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer PluginEditorAPISplit;
        private System.Windows.Forms.TabControl PluginEditorAPITreeTabs;
        private System.Windows.Forms.TabPage PluginEditorPythonAPITreeTab;
        internal System.Windows.Forms.TreeView PluginEditorPythonAPITree;
        private System.Windows.Forms.TabPage PluginEditorRubyAPITreeTab;
        internal System.Windows.Forms.TreeView PluginEditorRubyAPITree;
        private System.Windows.Forms.RichTextBox PluginEditorAPIDetailsRTB;
        internal System.Windows.Forms.TextBox PluginEditorErrorTB;
        private System.Windows.Forms.SplitContainer PluginEditorRightSplit;
        private System.Windows.Forms.OpenFileDialog PluginEditorOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog PluginEditorSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ActivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passivePluginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatPluginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sessionPluginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPyActivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRbActivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPyPassivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRbPassivePluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPySessionPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRbSessionPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPyFormatPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRbFormatPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPyScriptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRbScriptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckSyntaxF5ToolStripMenuItem;
    }
}