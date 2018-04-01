using System.Globalization;
using System.Threading;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    partial class FRM_Main
    {
        /// <summary>
        /// متغیر طراحی مورد نیاز
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// هر منبعی که استفاده شده را پاک کنید.
        /// </summary>
        /// <param name="disposing">درست اگر منابع مدیریت شده باید گذاشته شود؛ در غیر این صورت، نادرست است</param>
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
        ///روش مورد نیاز برای پشتیبانی طراح - تغییر نکنید
        /// محتویات این روش را با ویرایشگر کد.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.B = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.RastClick_treeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archiveLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBoxShow_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ShowSearchpanel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer_PM_RTF = new System.Windows.Forms.SplitContainer();
            this.customRichTextBox1 = new Zamtalk_Pm_Reader__vr_1._0._0._0.CustomRichTextBox();
            this.RastClick_RichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSpliterMini = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ListBoxRTFshode = new System.Windows.Forms.ListBox();
            this.ListBoxKhatKhatShode = new System.Windows.Forms.ListBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchAndHighlight = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.BTN_Reload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuEdite = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_archiveLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEdit_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEdit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEdit_AddToShearch = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdite_HideSearchBox = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdite_ShowSearchBox = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_showEmoji = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_hideEmoji = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_settingsDir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_findPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_FontChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit_Versioninfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.B.Panel1.SuspendLayout();
            this.B.Panel2.SuspendLayout();
            this.B.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RastClick_treeView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_PM_RTF)).BeginInit();
            this.splitContainer_PM_RTF.Panel1.SuspendLayout();
            this.splitContainer_PM_RTF.Panel2.SuspendLayout();
            this.splitContainer_PM_RTF.SuspendLayout();
            this.RastClick_RichTextBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_search.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuEdite.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // B
            // 
            resources.ApplyResources(this.B, "B");
            this.B.Name = "B";
            // 
            // B.Panel1
            // 
            this.B.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.B.Panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.B.Panel1, "B.Panel1");
            // 
            // B.Panel2
            // 
            this.B.Panel2.BackColor = System.Drawing.Color.Coral;
            this.B.Panel2.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.B.Panel2, "B.Panel2");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.treeView1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.RastClick_treeView;
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // RastClick_treeView
            // 
            this.RastClick_treeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveLoadToolStripMenuItem,
            this.openToolStripMenuItem,
            this.searchBoxShow_TSMI,
            this.CMS_ShowSearchpanel});
            this.RastClick_treeView.Name = "contextMenuStrip2";
            resources.ApplyResources(this.RastClick_treeView, "RastClick_treeView");
            // 
            // archiveLoadToolStripMenuItem
            // 
            this.archiveLoadToolStripMenuItem.Name = "archiveLoadToolStripMenuItem";
            resources.ApplyResources(this.archiveLoadToolStripMenuItem, "archiveLoadToolStripMenuItem");
            this.archiveLoadToolStripMenuItem.Click += new System.EventHandler(this.ArchiveLoadToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // searchBoxShow_TSMI
            // 
            this.searchBoxShow_TSMI.Name = "searchBoxShow_TSMI";
            resources.ApplyResources(this.searchBoxShow_TSMI, "searchBoxShow_TSMI");
            this.searchBoxShow_TSMI.Click += new System.EventHandler(this.SearchBoxShowToolStripMenuItem_Click);
            // 
            // CMS_ShowSearchpanel
            // 
            this.CMS_ShowSearchpanel.Name = "CMS_ShowSearchpanel";
            resources.ApplyResources(this.CMS_ShowSearchpanel, "CMS_ShowSearchpanel");
            this.CMS_ShowSearchpanel.Click += new System.EventHandler(this.CMS_ShowSearchpanel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.splitContainer_PM_RTF);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // splitContainer_PM_RTF
            // 
            this.splitContainer_PM_RTF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.splitContainer_PM_RTF, "splitContainer_PM_RTF");
            this.splitContainer_PM_RTF.Name = "splitContainer_PM_RTF";
            // 
            // splitContainer_PM_RTF.Panel1
            // 
            this.splitContainer_PM_RTF.Panel1.Controls.Add(this.customRichTextBox1);
            this.splitContainer_PM_RTF.Panel1.Controls.Add(this.BtnSpliterMini);
            // 
            // splitContainer_PM_RTF.Panel2
            // 
            this.splitContainer_PM_RTF.Panel2.AllowDrop = true;
            resources.ApplyResources(this.splitContainer_PM_RTF.Panel2, "splitContainer_PM_RTF.Panel2");
            this.splitContainer_PM_RTF.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer_PM_RTF.Panel2.Controls.Add(this.richTextBox4);
            this.splitContainer_PM_RTF.DoubleClick += new System.EventHandler(this.SplitContainer1_DoubleClick);
            // 
            // customRichTextBox1
            // 
            this.customRichTextBox1.AutoWordSelection = true;
            this.customRichTextBox1.ContextMenuStrip = this.RastClick_RichTextBox;
            resources.ApplyResources(this.customRichTextBox1, "customRichTextBox1");
            this.customRichTextBox1.EnableAutoDragDrop = true;
            this.customRichTextBox1.Name = "customRichTextBox1";
            this.customRichTextBox1.TextChanged += new System.EventHandler(this.CustomRichTextBox1_TextChanged);
            // 
            // RastClick_RichTextBox
            // 
            this.RastClick_RichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.addToSearchToolStripMenuItem});
            this.RastClick_RichTextBox.Name = "contextMenuStrip1";
            resources.ApplyResources(this.RastClick_RichTextBox, "RastClick_RichTextBox");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // addToSearchToolStripMenuItem
            // 
            this.addToSearchToolStripMenuItem.Name = "addToSearchToolStripMenuItem";
            resources.ApplyResources(this.addToSearchToolStripMenuItem, "addToSearchToolStripMenuItem");
            this.addToSearchToolStripMenuItem.Click += new System.EventHandler(this.AddToSearchToolStripMenuItem_Click);
            // 
            // BtnSpliterMini
            // 
            this.BtnSpliterMini.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.BtnSpliterMini, "BtnSpliterMini");
            this.BtnSpliterMini.FlatAppearance.BorderSize = 0;
            this.BtnSpliterMini.Name = "BtnSpliterMini";
            this.BtnSpliterMini.UseVisualStyleBackColor = false;
            this.BtnSpliterMini.Click += new System.EventHandler(this.BtnSpliterMini_Click);
            // 
            // richTextBox4
            // 
            resources.ApplyResources(this.richTextBox4, "richTextBox4");
            this.richTextBox4.Name = "richTextBox4";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.ListBoxRTFshode);
            this.panel2.Controls.Add(this.ListBoxKhatKhatShode);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // ListBoxRTFshode
            // 
            this.ListBoxRTFshode.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxRTFshode, "ListBoxRTFshode");
            this.ListBoxRTFshode.Name = "ListBoxRTFshode";
            this.ListBoxRTFshode.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // ListBoxKhatKhatShode
            // 
            resources.ApplyResources(this.ListBoxKhatKhatShode, "ListBoxKhatKhatShode");
            this.ListBoxKhatKhatShode.FormattingEnabled = true;
            this.ListBoxKhatKhatShode.Name = "ListBoxKhatKhatShode";
            this.ListBoxKhatKhatShode.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoToolTip = true;
            this.toolStripProgressBar1.BackColor = System.Drawing.Color.Coral;
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.groupBox_search);
            this.groupBox3.Controls.Add(this.BTN_Reload);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.groupBox5);
            this.groupBox_search.Controls.Add(this.lblSearch);
            this.groupBox_search.Controls.Add(this.label1);
            this.groupBox_search.Controls.Add(this.cboSearch);
            this.groupBox_search.Controls.Add(this.btnSearchAndHighlight);
            this.groupBox_search.Controls.Add(this.panelColor);
            resources.ApplyResources(this.groupBox_search, "groupBox_search");
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkMatchCase);
            this.groupBox5.Controls.Add(this.chkMatchWholeWord);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // chkMatchCase
            // 
            resources.ApplyResources(this.chkMatchCase, "chkMatchCase");
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkMatchWholeWord
            // 
            resources.ApplyResources(this.chkMatchWholeWord, "chkMatchWholeWord");
            this.chkMatchWholeWord.Name = "chkMatchWholeWord";
            this.chkMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.Name = "lblSearch";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            resources.ApplyResources(this.cboSearch, "cboSearch");
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.TextChanged += new System.EventHandler(this.CboSearch_TextChanged);
            this.cboSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSearch_KeyPress);
            // 
            // btnSearchAndHighlight
            // 
            resources.ApplyResources(this.btnSearchAndHighlight, "btnSearchAndHighlight");
            this.btnSearchAndHighlight.Name = "btnSearchAndHighlight";
            this.btnSearchAndHighlight.UseVisualStyleBackColor = true;
            this.btnSearchAndHighlight.Click += new System.EventHandler(this.BtnSearchAndHighlight_Click);
            // 
            // panelColor
            // 
            resources.ApplyResources(this.panelColor, "panelColor");
            this.panelColor.BackColor = System.Drawing.Color.Red;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelColor.Name = "panelColor";
            this.panelColor.Click += new System.EventHandler(this.PanelColor_Click);
            // 
            // BTN_Reload
            // 
            resources.ApplyResources(this.BTN_Reload, "BTN_Reload");
            this.BTN_Reload.Name = "BTN_Reload";
            this.BTN_Reload.UseVisualStyleBackColor = true;
            this.BTN_Reload.Click += new System.EventHandler(this.BTN_Reload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.StatusBar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // MenuEdite
            // 
            this.MenuEdite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.MenuEdite, "MenuEdite");
            this.MenuEdite.Name = "MenuEdite";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdit_archiveLoad,
            this.MenuEdit_open,
            this.toolStripSeparator4,
            this.MenuEdit_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // MenuEdit_archiveLoad
            // 
            this.MenuEdit_archiveLoad.Name = "MenuEdit_archiveLoad";
            resources.ApplyResources(this.MenuEdit_archiveLoad, "MenuEdit_archiveLoad");
            this.MenuEdit_archiveLoad.Click += new System.EventHandler(this.ArchiveLoadToolStripMenuItem1_Click);
            // 
            // MenuEdit_open
            // 
            this.MenuEdit_open.Name = "MenuEdit_open";
            resources.ApplyResources(this.MenuEdit_open, "MenuEdit_open");
            this.MenuEdit_open.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // MenuEdit_Exit
            // 
            this.MenuEdit_Exit.Name = "MenuEdit_Exit";
            resources.ApplyResources(this.MenuEdit_Exit, "MenuEdit_Exit");
            this.MenuEdit_Exit.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdit_Undo,
            this.MenuEdit_Redo,
            this.toolStripSeparator3,
            this.MenuEdit_Cut,
            this.MenuEdit_Copy,
            this.MenuEdit_Paste,
            this.MenuEdit_SelectAll,
            this.MenuEdit_Clear,
            this.toolStripSeparator7,
            this.MenuEdit_AddToShearch});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // MenuEdit_Undo
            // 
            this.MenuEdit_Undo.Name = "MenuEdit_Undo";
            resources.ApplyResources(this.MenuEdit_Undo, "MenuEdit_Undo");
            this.MenuEdit_Undo.Click += new System.EventHandler(this.UndoToolStripMenuItem1_Click);
            // 
            // MenuEdit_Redo
            // 
            this.MenuEdit_Redo.Name = "MenuEdit_Redo";
            resources.ApplyResources(this.MenuEdit_Redo, "MenuEdit_Redo");
            this.MenuEdit_Redo.Click += new System.EventHandler(this.RedoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // MenuEdit_Cut
            // 
            this.MenuEdit_Cut.Name = "MenuEdit_Cut";
            resources.ApplyResources(this.MenuEdit_Cut, "MenuEdit_Cut");
            this.MenuEdit_Cut.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // MenuEdit_Copy
            // 
            this.MenuEdit_Copy.Name = "MenuEdit_Copy";
            resources.ApplyResources(this.MenuEdit_Copy, "MenuEdit_Copy");
            this.MenuEdit_Copy.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // MenuEdit_Paste
            // 
            this.MenuEdit_Paste.Name = "MenuEdit_Paste";
            resources.ApplyResources(this.MenuEdit_Paste, "MenuEdit_Paste");
            this.MenuEdit_Paste.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // MenuEdit_SelectAll
            // 
            this.MenuEdit_SelectAll.Name = "MenuEdit_SelectAll";
            resources.ApplyResources(this.MenuEdit_SelectAll, "MenuEdit_SelectAll");
            this.MenuEdit_SelectAll.Click += new System.EventHandler(this.SelectAllToolStripMenuItem1_Click);
            // 
            // MenuEdit_Clear
            // 
            this.MenuEdit_Clear.Name = "MenuEdit_Clear";
            resources.ApplyResources(this.MenuEdit_Clear, "MenuEdit_Clear");
            this.MenuEdit_Clear.Click += new System.EventHandler(this.ClearToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // MenuEdit_AddToShearch
            // 
            this.MenuEdit_AddToShearch.Name = "MenuEdit_AddToShearch";
            resources.ApplyResources(this.MenuEdit_AddToShearch, "MenuEdit_AddToShearch");
            this.MenuEdit_AddToShearch.Click += new System.EventHandler(this.AddToSearchToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdite_HideSearchBox,
            this.MenuEdite_ShowSearchBox,
            this.MenuEdit_showEmoji,
            this.MenuEdit_hideEmoji});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // MenuEdite_HideSearchBox
            // 
            this.MenuEdite_HideSearchBox.Name = "MenuEdite_HideSearchBox";
            resources.ApplyResources(this.MenuEdite_HideSearchBox, "MenuEdite_HideSearchBox");
            this.MenuEdite_HideSearchBox.Click += new System.EventHandler(this.SearchBoxShowToolStripMenuItem1_Click);
            // 
            // MenuEdite_ShowSearchBox
            // 
            this.MenuEdite_ShowSearchBox.Name = "MenuEdite_ShowSearchBox";
            resources.ApplyResources(this.MenuEdite_ShowSearchBox, "MenuEdite_ShowSearchBox");
            this.MenuEdite_ShowSearchBox.Click += new System.EventHandler(this.SearchBoxHideToolStripMenuItem_Click);
            // 
            // MenuEdit_showEmoji
            // 
            this.MenuEdit_showEmoji.Name = "MenuEdit_showEmoji";
            resources.ApplyResources(this.MenuEdit_showEmoji, "MenuEdit_showEmoji");
            this.MenuEdit_showEmoji.Click += new System.EventHandler(this.ShowEmojiToolStripMenuItem_Click_1);
            // 
            // MenuEdit_hideEmoji
            // 
            this.MenuEdit_hideEmoji.Name = "MenuEdit_hideEmoji";
            resources.ApplyResources(this.MenuEdit_hideEmoji, "MenuEdit_hideEmoji");
            this.MenuEdit_hideEmoji.Click += new System.EventHandler(this.HideEmojiToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdit_settingsDir,
            this.MenuEdit_findPassword,
            this.MenuEdit_FontChange,
            this.MenuEdit_Language});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // MenuEdit_settingsDir
            // 
            this.MenuEdit_settingsDir.Name = "MenuEdit_settingsDir";
            resources.ApplyResources(this.MenuEdit_settingsDir, "MenuEdit_settingsDir");
            this.MenuEdit_settingsDir.Click += new System.EventHandler(this.SettingsToolStripMenuItem1_Click);
            // 
            // MenuEdit_findPassword
            // 
            this.MenuEdit_findPassword.Name = "MenuEdit_findPassword";
            resources.ApplyResources(this.MenuEdit_findPassword, "MenuEdit_findPassword");
            this.MenuEdit_findPassword.Click += new System.EventHandler(this.FindPasswordToolStripMenuItem_Click);
            // 
            // MenuEdit_FontChange
            // 
            this.MenuEdit_FontChange.Name = "MenuEdit_FontChange";
            resources.ApplyResources(this.MenuEdit_FontChange, "MenuEdit_FontChange");
            this.MenuEdit_FontChange.Click += new System.EventHandler(this.تغییرفونتToolStripMenuItem_Click_1);
            // 
            // MenuEdit_Language
            // 
            this.MenuEdit_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enToolStripMenuItem,
            this.frToolStripMenuItem});
            this.MenuEdit_Language.Name = "MenuEdit_Language";
            resources.ApplyResources(this.MenuEdit_Language, "MenuEdit_Language");
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            resources.ApplyResources(this.enToolStripMenuItem, "enToolStripMenuItem");
            this.enToolStripMenuItem.Click += new System.EventHandler(this.EnToolStripMenuItem_Click);
            // 
            // frToolStripMenuItem
            // 
            this.frToolStripMenuItem.Name = "frToolStripMenuItem";
            resources.ApplyResources(this.frToolStripMenuItem, "frToolStripMenuItem");
            this.frToolStripMenuItem.Click += new System.EventHandler(this.FrToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEdit_Versioninfo});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // MenuEdit_Versioninfo
            // 
            this.MenuEdit_Versioninfo.Name = "MenuEdit_Versioninfo";
            resources.ApplyResources(this.MenuEdit_Versioninfo, "MenuEdit_Versioninfo");
            this.MenuEdit_Versioninfo.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MenuEdite);
            this.panel3.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // FRM_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FRM_Main";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.B.Panel1.ResumeLayout(false);
            this.B.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.B.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.RastClick_treeView.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer_PM_RTF.Panel1.ResumeLayout(false);
            this.splitContainer_PM_RTF.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_PM_RTF)).EndInit();
            this.splitContainer_PM_RTF.ResumeLayout(false);
            this.RastClick_RichTextBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuEdite.ResumeLayout(false);
            this.MenuEdite.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer B;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Reload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuEdite;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Exit;
        private System.Windows.Forms.ContextMenuStrip RastClick_RichTextBox;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip RastClick_treeView;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox ListBoxRTFshode;
        private System.Windows.Forms.ListBox ListBoxKhatKhatShode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer_PM_RTF;
        private System.Windows.Forms.Button BtnSpliterMini;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkMatchWholeWord;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAndHighlight;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripMenuItem addToSearchToolStripMenuItem;
        public Zamtalk_Pm_Reader__vr_1._0._0._0.CustomRichTextBox customRichTextBox1;
        private System.Windows.Forms.ToolStripMenuItem searchBoxShow_TSMI;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Undo;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Cut;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Copy;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Paste;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_AddToShearch;
        private System.Windows.Forms.ToolStripMenuItem MenuEdite_HideSearchBox;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_settingsDir;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_findPassword;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Versioninfo;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_FontChange;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_open;
        private System.Windows.Forms.ToolStripMenuItem archiveLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_archiveLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_Language;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEdite_ShowSearchBox;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_showEmoji;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit_hideEmoji;
        private System.Windows.Forms.ToolStripMenuItem CMS_ShowSearchpanel;
    }
}

