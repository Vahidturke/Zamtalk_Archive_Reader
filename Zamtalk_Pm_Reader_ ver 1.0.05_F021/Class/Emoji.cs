using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021.Properties;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class Emoji
    {

        private RichTextBox richTextBox1 = new RichTextBox();
        private Hashtable emotions;

        #region سازنده ها
        public Hashtable Emotions { get => emotions; set => emotions = value; }

        public Emoji(Hashtable emoj)
        {
            this.Emotions = emoj;
        }

        public Emoji(RichTextBox richTextBox1, Hashtable emotions)
        {
            this.richTextBox1 = richTextBox1;
            this.Emotions = emotions;
        }

        public Emoji(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;
        }

        public Emoji()
        {
        }
        #endregion

        public void CreateEmotions()
        {
            Emotions = new Hashtable(136);

            #region Radif 1
            Emotions.Add("[:)", Resources.R_01__1_);
            Emotions.Add("[:(", Resources.R_01__2_);
            Emotions.Add("[;)", Resources.R_01__3_);

            Emotions.Add("[:D", Resources.R_01__4_);
            Emotions.Add("[:d", Resources.R_01__4_);

            Emotions.Add("[;;)", Resources.R_01__5_);

            Emotions.Add("[:-DD", Resources.R_01__6_);
            Emotions.Add("[:-dd", Resources.R_01__6_);

            Emotions.Add("[>:-D<", Resources.R_01__7_);
            Emotions.Add("[>:-d<", Resources.R_01__7_);

            Emotions.Add("[:ty", Resources.R_01__8_);

            Emotions.Add("[:x", Resources.R_01__9_);
            Emotions.Add("[:X", Resources.R_01__9_);

            Emotions.Add("[:TY", Resources.R_01__8_);
            Emotions.Add("[:Ty", Resources.R_01__8_);
            Emotions.Add("[:tY", Resources.R_01__8_);

            #endregion

            #region Radif 2

            Emotions.Add("[:\">", Resources.R_02__1_);
            Emotions.Add("[:P", Resources.R_02__2_);
            Emotions.Add("[:*", Resources.R_02__3_);
            Emotions.Add("[=((", Resources.R_02__4_);
            Emotions.Add("[:O", Resources.R_02__5_);
            Emotions.Add("[X(", Resources.R_02__6_);
            Emotions.Add("[:->", Resources.R_02__7_);
            Emotions.Add("[:B-)", Resources.R_02__8_);
            Emotions.Add("[:SR", Resources.R_02__9_);

            #endregion

            #region Radif 3

            Emotions.Add("[:-s", Resources.R_03__1_);
            Emotions.Add("[=D>", Resources.R_03__2_);
            Emotions.Add("[:C(", Resources.R_03__3_);
            Emotions.Add("[:-((", Resources.R_03__4_);
            Emotions.Add("[:H)", Resources.R_03__5_);
            Emotions.Add("[:h)", Resources.R_03__5_);
            Emotions.Add("[=))", Resources.R_03__6_);
            Emotions.Add(@"[\:-D/", Resources.R_03__7_);
            Emotions.Add("[:-PP", Resources.R_03__8_);
            Emotions.Add("[(-X", Resources.R_03__9_);

            #endregion

            #region Radif 4

            Emotions.Add("[:fight", Resources.R_04__1_);
            Emotions.Add("[:ST", Resources.R_04__2_);
            Emotions.Add("[#-O", Resources.R_04__3_);
            Emotions.Add("[<:-P", Resources.R_04__4_);
            Emotions.Add("[--X(", Resources.R_04__5_);
            Emotions.Add("[\\;)", Resources.R_04__6_);
            Emotions.Add("[#-ST", Resources.R_04__7_);
            Emotions.Add("[:-)]", Resources.R_04__8_);
            Emotions.Add("[:?", Resources.R_04__9_);

            #endregion

            #region Radif 5

            Emotions.Add("[(-(", Resources.R_05__1_);
            Emotions.Add("[#-BO", Resources.R_05__2_);
            Emotions.Add("[8->", Resources.R_05__3_);
            Emotions.Add("[:BZ", Resources.R_05__4_);
            Emotions.Add("[(MU)", Resources.R_05__5_);
            Emotions.Add("[:-DA", Resources.R_05__6_);
            Emotions.Add("[:-RF", Resources.R_05__7_);
            Emotions.Add("[::))", Resources.R_05__8_);
            Emotions.Add("[:-*)", Resources.R_05__9_);

            #endregion

            #region Radif 6

            Emotions.Add("[:-HK", Resources.R_06__1_);
            Emotions.Add("[:-H", Resources.R_06__2_);
            Emotions.Add("[:Help", Resources.R_06__3_);
            Emotions.Add("[:-??", Resources.R_06__4_);
            Emotions.Add("[:-FD", Resources.R_06__5_);
            Emotions.Add("[(dance)", Resources.R_06__6_);
            Emotions.Add("[#-HH", Resources.R_06__7_);
            Emotions.Add("[:smoking", Resources.R_06__8_);
            Emotions.Add("[~O)", Resources.R_06__9_);
            #endregion

            #region Radif 7

            Emotions.Add("[#:RB", Resources.R_07__1_);
            Emotions.Add("[:-BU", Resources.R_07__2_);
            Emotions.Add("[:-FO", Resources.R_07__3_);
            Emotions.Add("[:-)>-", Resources.R_07__4_);
            Emotions.Add("[<3", Resources.R_07__5_);
            Emotions.Add("[#-NS", Resources.R_07__6_);
            Emotions.Add("[@};-", Resources.R_07__7_);
            Emotions.Add("[:-OM", Resources.R_07__8_);
            Emotions.Add("[:-FL", Resources.R_07__9_);

            #endregion

            #region Radif 8
            Emotions.Add("[:-BD", Resources.R_08__1_);
            Emotions.Add("[(:|", Resources.R_08__2_);
            Emotions.Add("[:-{K", Resources.R_08__3_);
            Emotions.Add("[:SC", Resources.R_08__4_);
            Emotions.Add("[:SB", Resources.R_08__5_);
            Emotions.Add("[:-FP", Resources.R_08__6_);
            Emotions.Add("[:SG", Resources.R_08__7_);
            Emotions.Add("[8-|", Resources.R_08__8_);
            Emotions.Add("[:FP2", Resources.R_08__9_);

            #endregion

            #region Radif 9

            Emotions.Add("[:HE", Resources.R_09__1_);
            Emotions.Add("[:HO", Resources.R_09__2_);
            Emotions.Add("[:-NF", Resources.R_09__3_);
            Emotions.Add("[/:/", Resources.R_09__4_);
            Emotions.Add("[:silly", Resources.R_09__5_);
            Emotions.Add("[:yawn", Resources.R_09__6_);
            Emotions.Add("[:-N", Resources.R_09__7_);
            Emotions.Add("[:-Y", Resources.R_09__8_);
            Emotions.Add("[:witch", Resources.R_09__9_);

            #endregion

            #region Radif 10
            /*
            #OM
            (-?
            :-"
            (-[
            =-D>>
            (-SC
            :bb
            #)
            :#Cake */

            Emotions.Add("[#OM", Resources.R_10__1_);
            Emotions.Add("[(-?", Resources.R_10__2_);
            Emotions.Add("[:-\"", Resources.R_10__3_);
            Emotions.Add("[(-[", Resources.R_10__4_);
            Emotions.Add("[=-D>>", Resources.R_10__5_);
            Emotions.Add("[(-SC", Resources.R_10__6_);
            Emotions.Add("[:bb", Resources.R_10__7_);
            Emotions.Add("[#)", Resources.R_10__8_);
            Emotions.Add("[:#Cake", Resources.R_10__9_);
            #endregion

            #region Radif 11
            /*
            ::DA
            ::PP
            :CH
            :BO
            :SH
            ::PR
            -:)_
            :-K
            :HR   */
            Emotions.Add("[::DA", Resources.R_11__1_);
            Emotions.Add("[::PP", Resources.R_11__2_);
            Emotions.Add("[:CH", Resources.R_11__3_);
            Emotions.Add("[:BO", Resources.R_11__4_);
            Emotions.Add("[:SH", Resources.R_11__5_);
            Emotions.Add("[::PR", Resources.R_11__6_);
            Emotions.Add("[-:)_", Resources.R_11__7_);
            Emotions.Add("[:-K", Resources.R_11__8_);
            Emotions.Add("[:HR ", Resources.R_11__9_);

            #endregion

            #region Radif 12
            /*
            :CL
            :BN
            (manicure)
            :RN
            (cheering)
            (computer)
            (shy)
            (guitarist)
            (singing)
            */
            Emotions.Add("[:CL", Resources.R_12__1_);
            Emotions.Add("[:BN", Resources.R_12__2_);
            Emotions.Add("[(manicure)", Resources.R_12__3_);
            Emotions.Add("[:RN", Resources.R_12__4_);
            Emotions.Add("[(cheering)", Resources.R_12__5_);
            Emotions.Add("[(computer)", Resources.R_12__6_);
            Emotions.Add("[(shy)", Resources.R_12__7_);
            Emotions.Add("[(guitarist)", Resources.R_12__8_);
            Emotions.Add("[(singing)", Resources.R_12__9_);

            #endregion

            #region Radif 13
            /*
            :bdance
            :bday
            (xmas)
            (clap)
            :hbd
            :hny
            (chl)
            :swim
            (xsnow)
            */
            Emotions.Add("[:bdance", Resources.R_13__1_);
            Emotions.Add("[:bday", Resources.R_13__2_);
            Emotions.Add("[(xmas)", Resources.R_13__3_);
            Emotions.Add("[(clap)", Resources.R_13__4_);
            Emotions.Add("[:hbd", Resources.R_13__5_);
            Emotions.Add("[:hny", Resources.R_13__6_);
            Emotions.Add("[(chl)", Resources.R_13__7_);
            Emotions.Add("[:swim", Resources.R_13__8_);
            Emotions.Add("[(xsnow)", Resources.R_13__9_);

            #endregion

            #region Radif 14
            /*
            (mario)
            (cook)
            (gig)
            (anni)
            (h.val)
            (bday)
            (rainbow)
            (hit)
            (head)
            */
            Emotions.Add("[(mario)", Resources.R_14__1_);
            Emotions.Add("[(cook)", Resources.R_14__2_);
            Emotions.Add("[(gig)", Resources.R_14__3_);
            Emotions.Add("[(anni)", Resources.R_14__4_);
            Emotions.Add("[(h.val)", Resources.R_14__5_);
            Emotions.Add("[(bday)", Resources.R_14__6_);
            Emotions.Add("[(rainbow)", Resources.R_14__7_);
            Emotions.Add("[(hit)", Resources.R_14__8_);
            Emotions.Add("[(head)", Resources.R_14__9_);

            #endregion

            #region Radif 15
            /*
            (wow)
            (lovebird)
            (b.day)
            (lol)
            (ilu)
            (cmptr)
            (pengu)
            (val)
            (kiss)
            */
            Emotions.Add("[(wow)", Resources.R_15__1_);
            Emotions.Add("[(lovebird)", Resources.R_15__2_);
            Emotions.Add("[(b.day)", Resources.R_15__3_);
            Emotions.Add("[(lol)", Resources.R_15__4_);
            Emotions.Add("[(ilu)", Resources.R_15__5_);
            Emotions.Add("[(cmptr)", Resources.R_15__6_);
            Emotions.Add("[(pengu)", Resources.R_15__7_);
            Emotions.Add("[(val)", Resources.R_15__8_);
            Emotions.Add("[(kiss)", Resources.R_15__9_);

            #endregion

        }

        public void AddEmotions()
        {
            foreach (string emote in Emotions.Keys)
            {
                try
                {
                    while (richTextBox1.Text.Contains(emote))
                    {
                        int ind = richTextBox1.Text.IndexOf(emote);
                        richTextBox1.Select(ind, emote.Length);
                        Clipboard.SetImage((Image)Emotions[emote]);
                        richTextBox1.Paste();
                    }

                }
                catch (Exception /*ex*/)
                {

                    //   MessageBox.Show(ex.ToString());
                }
            }
        }

        public void FontChange(RichTextBox richTextBox)
        {
            FontDialog fpanel = new FontDialog
            {
                ShowColor = true
            };
            richTextBox1.Font = fpanel.Font;
            richTextBox1.ForeColor = fpanel.Color;

            if (fpanel.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fpanel.Font;
                richTextBox1.ForeColor = fpanel.Color;
            }
        }




        ImageList MyimageList = new ImageList();
        ListViewItem MyListViewItem = new ListViewItem();
        List<string> MyListText = new List<string>();
        // Emoji MyEmoji = new Emoji();
        // Hashtable MyHashtable = new Hashtable();

        public void FillListView(ListView MylistView)
        {
            MylistView.Columns.Add(text: "Emoji");
            MylistView.Columns.Add(text: "Text");
            MylistView.GridLines = true;
            MylistView.View = View.Details;

            CreateEmotions();
            AddEmotions();

            MylistView.SmallImageList = MyimageList;

            foreach (var item in emotions.Keys)
            {
                MyListText.Add(item.ToString());
            }
            foreach (var item in MyListText)
            {
                MyListViewItem.SubItems.Add(item);
            }
            foreach (Image Aks in emotions.Values)
            {
                MyimageList.Images.Add(Aks);
            }
            for (int i = 0; i < MyimageList.Images.Count; ++i)
            {
                ListViewItem item = new ListViewItem { ImageIndex = i };

                MylistView.Items.Add(item).SubItems.Add(MyListText[i]);
            }
        }
    }

}

