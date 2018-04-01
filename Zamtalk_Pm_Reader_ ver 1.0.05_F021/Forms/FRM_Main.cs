using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using Zamtalk_Pm_Reader__ver_1._0._05_F021;
using System.Collections;
using System.Text.RegularExpressions;
using System.Linq;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.InitializeComponent();
            enToolStripMenuItem.Enabled = false;

        }

        public static string filename = "copyarchive.txt";
        public static string foldername = "copyarchive";

        public List<string> ArchivePaths = new List<string>();

        #region متغیر ها

        #region آبجکت

        private TempMakers oTempMakers = new TempMakers();
        private FRM_Settings oFRM_Settings = new FRM_Settings();
        private FRM_ZamtalkPasswordFinder oFRM_ZamtalkPasswordFinder = new FRM_ZamtalkPasswordFinder();
        private PmExplorer oPmExplorer = new PmExplorer();
        private Password oPassword = new Password();
        private Emoji oEmoji = new Emoji();
        private AboutBox1 oAboutBox1 = new AboutBox1();
        private Finder oFinder = new Finder();
        private SaveAndLoad oSaveAndLoad = new SaveAndLoad();

        #endregion

        #region متغیر

        private TextBox AllText = new TextBox();
        private TextBox IDText = new TextBox();
        private TextBox PmText = new TextBox();
        private TextBox ColorID = new TextBox();
        private TextBox PmColor = new TextBox();
        private RichTextBox RT_Aval = new RichTextBox();
        private RichTextBox richTextBox3 = new RichTextBox();
        private bool ShowSearchBox = false;

        private bool ShowEmoji = false;

        private Size StartSize = new Size(750, 420);

        public static string Farsi
        {
            get
            {
                return Farsi;
            }
            internal set
            {
                Farsi = value;
            }
        }



        #endregion


        #endregion

        #region متدها

        public void Loaderstartwindows()
        {

            this.groupBox3.Size = new Size(groupBox3.Width, 50);

            groupBox_search.Visible = ShowSearchBox;

            this.Size = StartSize;

            splitContainer_PM_RTF.Panel2Collapsed = true;

            TempMakers.AppdataFolder(FRM_Settings.foldername);

            this.WindowState = FormWindowState.Normal;

            this.StartPosition = FormStartPosition.CenterScreen;

            oSaveAndLoad.LoadData_UnderMsg(listBox1, TempMakers.AppDataFile(filename));

            listBox1.Visible = false;
            // TSMI_HideEmoji.Visible = false;
        }


        /// <summary>
        /// متد دکمه لود کردن آرشیو
        /// </summary>
        public void ReloadArchive()
        {
            TreeviewClearAllItems();

            SaveAndLoad oSaveAndLoad = new SaveAndLoad();

            oSaveAndLoad.LoadData_UnderMsg(listBox1, TempMakers.AppDataFile(filename));

            if (treeView1.Nodes.Count < 1)
            {
                CopyDir.StaticCopy(listBox1, treeView1, "");
            }
        }
        public string SelectedTreeviewfullpath(TreeView treeView)
        {

            treeView = treeView1;

            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + treeView.SelectedNode.FullPath;

        }
        public void ConfigForShowPm_in_richtextbox(ListBox lb, ListBox lsbox2, RichTextBox rt1)
        {
            customRichTextBox1.Clear();

            ListBoxKhatKhatShode.Items.Clear();

            ListBoxRTFshode.Items.Clear();

            lb = new ListBox();

            for (int i = 0; i < customRichTextBox1.Lines.Length; i++)
            {
                lb.Items.Add(customRichTextBox1.Lines[i]);
            }

            try
            {
                rt1.LoadFile(SelectedTreeviewfullpath(treeView1), RichTextBoxStreamType.UnicodePlainText);

                Btn1(rt1, ListBoxKhatKhatShode);

                for (int i = 0; i < lsbox2.Items.Count; i++)
                {
                    ListBoxRTFshode.SelectedItem = lsbox2.Items[i];

                }
            }
            catch (Exception) { }
        }
        public void Btn1(RichTextBox txt, ListBox lsbox1)
        {
            txt.LoadFile(SelectedTreeviewfullpath(treeView1), RichTextBoxStreamType.UnicodePlainText);

            oFinder.NewlineAndAddToListBox(txt, lsbox1.Items);

            for (int i = 0; i < ListBoxKhatKhatShode.Items.Count; i++)
            {
                ListBoxKhatKhatShode.SelectedIndex = i;

                toolStripProgressBar1.Maximum = ListBoxKhatKhatShode.Items.Count - 1;

                toolStripProgressBar1.Visible = Enabled;

                toolStripProgressBar1.Size = new Size(this.Width / 3, 12);

                toolStripProgressBar1.Value = i;


            }
        }
        public void AllRuner(string allpm)
        {
            //1
            AllText.Text = allpm;

            //2  
            IDText.Text = oFinder.FixID(allpm);

            //3
            PmText.Text = oFinder.PM(allpm);

            //4
            ColorID.Text = oFinder.FColorstart(allpm);

            //5
            PmColor.Text = oFinder.FColorEnd(allpm);

            //6
            oFinder.EditID(allpm);

            //7
            oFinder.Editpm(allpm);

            //8
            oFinder.PmRemoveTag(PmText);

            //9
            richTextBox2.Text = oFinder.Finish(ListBoxKhatKhatShode, PmText);

        }
        public void Converttostrinbuilder(ListBox _listboxRTFShode, RichTextBox rich1, RichTextBox rich2)
        {
            StringBuilder s = new StringBuilder();

            s.AppendLine(rich1.SelectedRtf = _listboxRTFShode.SelectedItem.ToString() + Environment.NewLine);

            rich2.Rtf = s.ToString();
        }



        #region متدهای منوی ادیت بالا

        #region File
        public void _Open()
        {
            try
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show(this, "Not Selected Item !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    Process.Start(SelectedTreeviewfullpath(treeView1).ToString());

                }
            }
            catch (Exception) { }

        }
        #endregion

        #region Edit

        public void _Cut(CustomRichTextBox arg)
        {
            arg.Cut();
        }
        public void _Copy(CustomRichTextBox arg)
        {
            arg.Copy();
        }
        public void _Paste(CustomRichTextBox arg)
        {
            arg.Paste();
        }
        public void _SelectAll(CustomRichTextBox arg)
        {
            arg.SelectAll();
        }
        public void _Clear(CustomRichTextBox arg)
        {
            arg.Clear();
        }
        public void _Undo(CustomRichTextBox arg)
        {
            arg.Undo();
        }
        public void _Redo(CustomRichTextBox arg)
        {
            arg.Redo();
        }
        private void AddToSearch(CustomRichTextBox customRichTextBox1)
        {
            cboSearch.Items.Add(customRichTextBox1.SelectedText);

            cboSearch.SelectedItem = customRichTextBox1.SelectedText;
        }

        #endregion

        #region view

        public void ShowEmojiScript(bool s)
        {
            if (s)
            {
                oEmoji = new Emoji(customRichTextBox1);

                oEmoji.CreateEmotions();

                oEmoji.AddEmotions();

                richTextBox4.Text = customRichTextBox1.Rtf;

            }
            else
            {

                return;

            }

        }

        #endregion

        #region Tools

        public void FontChange()
        {

            oEmoji.FontChange(customRichTextBox1);

        }
     
        /// <summary>
        /// متد تغییر زبان برنامه
        /// </summary>
        /// <param name="c"></param>
        public void ChangeLang(Form c)
        {
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "fa-IR":

                    c.Controls.Clear();

                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                    this.InitializeComponent();

                    enToolStripMenuItem.Enabled = false;

                    frToolStripMenuItem.Enabled = true;

                    this.Loaderstartwindows();

                    break;

                case "en-US":

                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");

                    this.Controls.Clear();

                    this.InitializeComponent();

                    this.frToolStripMenuItem.Enabled = false;

                    this.enToolStripMenuItem.Enabled = true;

                    this.Loaderstartwindows();


                    break;

                default:
                    break;

            }

        }



        #endregion

        #endregion

        #endregion

        #region رویدادها 

        #region رویدادهای خود فرم

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            Loaderstartwindows();

        }


        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                ConfigForShowPm_in_richtextbox(ListBoxKhatKhatShode, ListBoxRTFshode, RT_Aval);

                customRichTextBox1.Text.Remove(0, 1);

                toolStripProgressBar1.Visible = Enabled;

                toolStripProgressBar1.Size = new Size(this.Width / 3, 12);

            }
            catch (Exception) { }

        }


        public void ListboxtoList()
        {
            FRM_Settings o = new FRM_Settings();

            foreach (var item in o.listBox1.Items)
            {
                ArchivePaths.Add(item.ToString());

            }
        }
        private void BTN_Reload_Click(object sender, EventArgs e)
        {
            ReloadArchive();
        }
        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
            ListBoxRTFshode.Items.Add(richTextBox2.Text);
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // numericUpDown1.Value = Convert.ToInt32(listBox1.SelectedIndex);
            try { AllRuner(ListBoxKhatKhatShode.SelectedItem.ToString()); } catch (Exception) { }

        }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Converttostrinbuilder(ListBoxRTFshode, customRichTextBox1, richTextBox3);
        }
        private void SplitContainer1_DoubleClick(object sender, EventArgs e)
        {
            if (!splitContainer_PM_RTF.Panel2Collapsed)
            {
                splitContainer_PM_RTF.Panel2Collapsed = true;
            }

        }
        private void BtnSpliterMini_Click(object sender, EventArgs e)
        {

            if (splitContainer_PM_RTF.Panel2Collapsed)
            {
                splitContainer_PM_RTF.Panel2Collapsed = false;
            }
            else
            {
                splitContainer_PM_RTF.Panel2Collapsed = true;
            }

        }

        #endregion

        #region رویدادهای منوی ادیت  بالا

        #region File

        private void ArchiveLoadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReloadArchive();
        }
        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Open();

        }
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }


        #endregion

        #region Edit

        private void UndoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Undo(customRichTextBox1);

        }

        private void RedoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Redo(customRichTextBox1);

        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Cut(customRichTextBox1);

        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Copy(customRichTextBox1);

        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Paste(customRichTextBox1);

        }

        private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _SelectAll(customRichTextBox1);

        }

        private void ClearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            _Clear(customRichTextBox1);

        }

        private void AddToSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AddToSearch(customRichTextBox1);
        }

        #endregion

        #region View
        private void SearchBoxShowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchBoxHidSHow();

            //  SearchPanelShow();
            //  searchBoxHideToolStripMenuItem.Visible = false;
        }
        private void ShowEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Tools

        private void SettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Settings f = new FRM_Settings();

            f.Show();
        }

        private void FindPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ZamtalkPasswordFinder f = new FRM_ZamtalkPasswordFinder();

            f.Show();

        }

        private void تغییرفونتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontChange();
        }

        #region تغییر زبان


        /// <summary>
        /// تبدیل زبانه برنامه به انگلیسی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang(this);
        }

        /// <summary>
        /// تبدیل زبانه برنامه به فارسی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLang(this);
        }

        #endregion

        #endregion

        #region About

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();

            f.Show();
        }

        #endregion

        #endregion

        #region رویدادهای جستجو

        private void BtnSearchAndHighlight_Click(object sender, EventArgs e)
        {
            bool isexist = customRichTextBox1.Highlight(cboSearch.Text, panelColor.BackColor, chkMatchCase.Checked, chkMatchWholeWord.Checked);

            if (!isexist)
            {
                MessageBox.Show(string.Format("Can't find the \"{0}\" in Archive Zamtalk Pm!", cboSearch.Text));
            }
            if (!cboSearch.Items.Contains(cboSearch.Text))
            {

                this.cboSearch.Items.Add(this.cboSearch.Text);

            }



        }
        private void PanelColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = this.panelColor.BackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    this.panelColor.BackColor = colorDialog.Color;

                }
            }
        }
        private void CboSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearchAndHighlight.PerformClick();

            }
        }
        private void CboSearch_TextChanged(object sender, EventArgs e)
        {
            // Disable the SearchAndHightlight button
            if (cboSearch.Text.Length == 0)
            {

                this.btnSearchAndHighlight.Enabled = false;

            }

            else
            {

                // Enable the SearchAndHightlight button
                this.btnSearchAndHighlight.Enabled = true;
            }
        }
        private void CustomRichTextBox1_TextChanged(object sender, EventArgs e)
        {

            customRichTextBox1.Rtf = customRichTextBox1.Rtf;

            //customRichTextBox1.Rtf =customRichTextBox1.Rtf.Replace(@" ]", newValue: Environment.NewLine).Replace(@"[","");

            richTextBox4.Text = customRichTextBox1.Rtf;

            ShowEmojiScript(ShowEmoji);

            // Fixer("^   ([\\]])", "A", customRichTextBox1.Rtf);


        }
        private string Fixer(string Pattern, string Replacement, string Input)
        {
            RegexOptions options = RegexOptions.IgnoreCase;

            Regex regex = new Regex(Pattern, options, TimeSpan.FromMilliseconds(1000));

            return regex.Replace(Input, Replacement);
        }


        #endregion

        #region  رویداد های راست کلیک 

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _Cut(customRichTextBox1);

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Copy(customRichTextBox1);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Paste(customRichTextBox1);
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SelectAll(customRichTextBox1);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Clear(customRichTextBox1);
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _Undo(customRichTextBox1);

        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Redo(customRichTextBox1);
        }

        private void AddToSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToSearch(customRichTextBox1);
        }
        private void SearchBoxShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBoxHidSHow();

        }
        private void ArchiveLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadArchive();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Open();
        }
        #endregion

        #endregion


        private void CMS_ShowSearchpanel_Click(object sender, EventArgs e)
        {
            SearchBoxHidSHow();
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HideEmojiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowEmoji = false;

            MenuEdit_hideEmoji.Visible = false;

            MenuEdit_showEmoji.Visible = true;

        }

        private void ShowEmojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowEmoji = true;

            MenuEdit_showEmoji.Visible = false;

            MenuEdit_hideEmoji.Visible = true;
        }

        private void SearchBoxHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBoxHidSHow();
        }

        public void TreeviewClearAllItems()
        {
            treeView1.Nodes.Clear();
        }

        public void SearchBoxHidSHow()
        {
            //گرفتن ارتفا پانل نمایش سرچ
            int _Height = groupBox3.Height;

            //گرفتن عرض پانل نمایش سرچ
            int _Width = groupBox3.Width;


            MenuEdite_HideSearchBox.Visible = true;

            MenuEdite_ShowSearchBox.Visible = false;

            CMS_ShowSearchpanel.Visible = false;

            if (!ShowSearchBox)
            {
                ShowSearchBox = true;

                searchBoxShow_TSMI.Visible = true;

                MenuEdite_ShowSearchBox.Visible = false;

                MenuEdite_HideSearchBox.Visible = true;

                CMS_ShowSearchpanel.Visible = false;

                groupBox3.Size = new Size(_Width, 120);

            }

            else if (ShowSearchBox)
            {
                ShowSearchBox = false;

                searchBoxShow_TSMI.Visible = false;

                MenuEdite_HideSearchBox.Visible = false;

                MenuEdite_ShowSearchBox.Visible = true;

                CMS_ShowSearchpanel.Visible = true;

                groupBox3.Size = new Size(_Width, 0);
            }

            groupBox_search.Visible = ShowSearchBox;

        }



        public void NodRefesh()
        {
            TreeNode a = treeView1.SelectedNode;

            treeView1.SelectedNode = treeView1.SelectedNode.NextNode;

            treeView1.SelectedNode = a;
        }

    }

}

class MyClass
{

    ListBox ls = new ListBox();
    private TreeView treeView1;

    public void AddNodeAndChildNodesToList(TreeNode node)
    {

        ls.Items.Add(node.Text);    // Adding current nodename to ListBox     

        foreach (TreeNode actualNode in node.Nodes)
        {
            AddNodeAndChildNodesToList(actualNode); // recursive call
        }
    }
    private void EnumerateAllNodes()
    {
        TreeView myTree = treeView1;

        var allNodes = myTree.Nodes
            .Cast<TreeNode>()
            .SelectMany(GetNodeBranch);

        foreach (var treeNode in allNodes)
        {
            treeView1.SelectedNode = treeNode;
            Thread.Sleep(3000);
        }
    }

    private IEnumerable<TreeNode> GetNodeBranch(TreeNode node)
    {
        yield return node;

        foreach (TreeNode child in node.Nodes)
            foreach (var childChild in GetNodeBranch(child))
                yield return childChild;
    }

}