using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        #region متغیر ها

        #region آبجکت

        private TempMakers oTempMakers = new TempMakers();
        private FRM_Settings fm = new FRM_Settings();
        private FRM_ZamtalkPasswordFinder fmpw = new FRM_ZamtalkPasswordFinder();
        private PmExplorer oPmExplorer = new PmExplorer();
        private Password oPassword = new Password();
        private FRM_ZamtalkPasswordFinder pw = new FRM_ZamtalkPasswordFinder();
        private Emoji Oemoji = new Emoji();
        private AboutBox1 oAboutBox1 = new AboutBox1();
        private Finder oFinder = new Finder();

        #endregion

        #region متغیر

        private RichTextBox RT_Aval = new RichTextBox();
        private List<RichTextBox> ListMytext_Text = new List<RichTextBox>();
        private List<string> ls = new List<string>();
        private TextBox AllText = new TextBox();
        private TextBox IDText = new TextBox();
        private TextBox PmText = new TextBox();
        private TextBox ColorID = new TextBox();
        private TextBox PmColor = new TextBox();
        private RichTextBox richTextBoxHide = new RichTextBox();
        private RichTextBox Mytext;
        private RichTextBox richTextBox3 = new RichTextBox();
        private bool SearchBoxShow = false;
        private Size StartSize = new Size(750, 420);
        private bool ShowEm = false;

        #endregion


        #endregion

        #region متدها


        /// <summary>
        /// متد دکمه لود کردن آرشیو
        /// </summary>
        public void ReloadArchive()
        {
            StaticCopy(fm.listBox1, treeView1, oTempMakers.AppdataFolder(FRM_Settings.foldername));
        }
        public void StaticCopy(ListBox listBox, TreeView treeView, string magasd)
        {
            magasd = oTempMakers.AppdataFolder(FRM_Settings.foldername);

            foreach (var item in listBox.Items)
            {

                CopyDir.Copy((string)item, magasd, true);
            }

            oPmExplorer.TreeViewexplorer(treeView, magasd);
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
            s.AppendLine(rich1.SelectedRtf = _listboxRTFShode.SelectedItem.ToString()
              + Environment.NewLine);
            rich2.Rtf = s.ToString();
        }
        public void AddControl()
        {
            Mytext = new RichTextBox();
            Controls.Add(Mytext);
            ListMytext_Text.Add(Mytext);
            Mytext.BorderStyle = BorderStyle.None;
            Mytext.Size = new Size(this.Width, 30);

            richTextBoxHide.SelectAll();
            richTextBoxHide.Copy();
            Mytext.Paste();
            customRichTextBox1.Paste();
        }
        private void SearchPanelShow()
        {
            //گرفتن ارتفا پانل نمایش سرچ
            int _Height = groupBox3.Height;
            //گرفتن عرض پانل نمایش سرچ
            int _Width = groupBox3.Width;

            if (!SearchBoxShow)
            {
                SearchBoxShow = true;

                searchBoxShowToolStripMenuItem.Text = "SearchBox Hide";
                searchBoxShowToolStripMenuItem1.Text = "SearchBox Hide";
                groupBox3.Size = new Size(_Width, 120);

            }
            else if (SearchBoxShow)
            {

                SearchBoxShow = false;

                searchBoxShowToolStripMenuItem.Text = "SearchBox Show";
                searchBoxShowToolStripMenuItem1.Text = "SearchBox Show";


                groupBox3.Size = new Size(_Width, 50);
            }

            groupBox_search.Visible = SearchBoxShow;

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
                Oemoji = new Emoji(customRichTextBox1);
                Oemoji.CreateEmotions();
                Oemoji.AddEmotions();
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
            Oemoji.FontChange(customRichTextBox1);
        }





        #endregion

        #endregion

        #endregion

        #region رویدادها 

        #region رویدادهای خود فرم

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            groupBox3.Size = new Size(groupBox3.Width, 50);
            groupBox_search.Visible = SearchBoxShow;
            this.Size = StartSize;

            splitContainer_PM_RTF.Panel2Collapsed = true;

            oTempMakers.AppdataFolder(FRM_Settings.foldername);


            // BTN_Reload.Text = Settings.Default["Title"].ToString();
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
            SearchPanelShow();
        }
        private void ShowEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowEm)
            {
                ShowEm = false;
                showEmojiToolStripMenuItem.Text = "Show Emoji";
            }
            else if (!ShowEm)
            {
                ShowEm = true;
                showEmojiToolStripMenuItem.Text = "Hide Emoji";
            }
        }

        #endregion

        #region Tools

        private void SettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fm.ShowDialog();
        }

        private void FindPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pw.ShowDialog();

        }

        private void تغییرفونتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontChange();
        }

        #endregion

        #region About

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oAboutBox1.Show();
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

            //Oemoji = new Emoji(customRichTextBox1);
            //Oemoji.CreateEmotions();
            //Oemoji.AddEmotions();

            //richTextBox4.Text = customRichTextBox1.Rtf;
            ShowEmojiScript(ShowEm);


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
            SearchPanelShow();
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


    }
}