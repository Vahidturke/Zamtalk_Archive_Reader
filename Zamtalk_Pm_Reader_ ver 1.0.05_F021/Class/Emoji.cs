using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021.Properties;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class Emoji
    {

        private RichTextBox richTextBox1 = new RichTextBox();

        private Hashtable emotions;

        public Emoji()
        {
        }

        public Emoji(RichTextBox richTextBox1, Hashtable emotions)
        {
            this.richTextBox1 = richTextBox1;
            this.emotions = emotions;
        }

        public Emoji(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;
        }

        public void CreateEmotions()
        {
            emotions = new Hashtable(136);

            #region Radif 1
            emotions.Add("[:)", Resources.R_01__1_);
            emotions.Add("[:(", Resources.R_01__2_);
            emotions.Add("[;)", Resources.R_01__3_);

            emotions.Add("[:D", Resources.R_01__4_);
            emotions.Add("[:d", Resources.R_01__4_);

            emotions.Add("[;;)", Resources.R_01__5_);

            emotions.Add("[:-DD", value: Resources.R_01__6_);
            emotions.Add("[:-dd", value: Resources.R_01__6_);

            emotions.Add("[>:-D<", Resources.R_01__7_);
            emotions.Add("[>:-d<", value: Resources.R_01__7_);

            emotions.Add("[:ty", Resources.R_01__8_);

            emotions.Add("[:x", Resources.R_01__9_);
            emotions.Add("[:X", Resources.R_01__9_);

            emotions.Add("[:TY", Resources.R_01__8_);
            emotions.Add("[:Ty", Resources.R_01__8_);
            emotions.Add("[:tY", Resources.R_01__8_);

            #endregion

            #region Radif 2

            emotions.Add("[:\">", Resources.R_02__1_);
            emotions.Add("[:P", Resources.R_02__2_);
            emotions.Add("[:*", Resources.R_02__3_);
            emotions.Add("[=((", Resources.R_02__4_);
            emotions.Add("[:O", Resources.R_02__5_);
            emotions.Add("[X(", Resources.R_02__6_);
            emotions.Add("[:->", Resources.R_02__7_);
            emotions.Add("[:B-)", Resources.R_02__8_);
            emotions.Add("[:SR", Resources.R_02__9_);

            #endregion

            #region Radif 3

            emotions.Add("[:-s", Resources.R_03__1_);
            emotions.Add("[=D>", Resources.R_03__2_);
            emotions.Add("[:C(", Resources.R_03__3_);
            emotions.Add("[:-((", Resources.R_03__4_);
            emotions.Add("[:H)", Resources.R_03__5_);
            emotions.Add("[:h)", Resources.R_03__5_);
            emotions.Add("[=))", Resources.R_03__6_);
            emotions.Add(@"[\:-D/", Resources.R_03__7_);
            emotions.Add("[:-PP", Resources.R_03__8_);
            emotions.Add("[(-X", Resources.R_03__9_);

            #endregion

            #region Radif 4

            emotions.Add("[:fight", Resources.R_04__1_);
            emotions.Add("[:ST", Resources.R_04__2_);
            emotions.Add("[#-O", Resources.R_04__3_);
            emotions.Add("[<:-P", Resources.R_04__4_);
            emotions.Add("[--X(", Resources.R_04__5_);
            emotions.Add("[\\;)", Resources.R_04__6_);
            emotions.Add("[#-ST", Resources.R_04__7_);
            emotions.Add("[:-)]", Resources.R_04__8_);
            emotions.Add("[:?", Resources.R_04__9_);

            #endregion

            #region Radif 5

            emotions.Add("[(-(", Resources.R_05__1_);
            emotions.Add("[#-BO", Resources.R_05__2_);
            emotions.Add("[8->", Resources.R_05__3_);
            emotions.Add("[:BZ", Resources.R_05__4_);
            emotions.Add("[(MU)", Resources.R_05__5_);
            emotions.Add("[:-DA", Resources.R_05__6_);
            emotions.Add("[:-RF", Resources.R_05__7_);
            emotions.Add("[::))", Resources.R_05__8_);
            emotions.Add("[:-*)", Resources.R_05__9_);

            #endregion

            #region Radif 6

            emotions.Add("[:-HK", Resources.R_06__1_);
            emotions.Add("[:-H", Resources.R_06__2_);
            emotions.Add("[:Help", Resources.R_06__3_);
            emotions.Add("[:-??", Resources.R_06__4_);
            emotions.Add("[:-FD", Resources.R_06__5_);
            emotions.Add("[(dance)", Resources.R_06__6_);
            emotions.Add("[#-HH", Resources.R_06__7_);
            emotions.Add("[:smoking", Resources.R_06__8_);
            emotions.Add("[~O)", Resources.R_06__9_);
            #endregion

            #region Radif 7

            emotions.Add("[#:RB", Resources.R_07__1_);
            emotions.Add("[:-BU", Resources.R_07__2_);
            emotions.Add("[:-FO", Resources.R_07__3_);
            emotions.Add("[:-)>-", Resources.R_07__4_);
            emotions.Add("[<3", Resources.R_07__5_);
            emotions.Add("[#-NS", Resources.R_07__6_);
            emotions.Add("[@};-", Resources.R_07__7_);
            emotions.Add("[:-OM", Resources.R_07__8_);
            emotions.Add("[:-FL", Resources.R_07__9_);

            #endregion

            #region Radif 8
            emotions.Add("[:-BD", Resources.R_08__1_);
            emotions.Add("[(:|", Resources.R_08__2_);
            emotions.Add("[:-{K", Resources.R_08__3_);
            emotions.Add("[:SC", Resources.R_08__4_);
            emotions.Add("[:SB", Resources.R_08__5_);
            emotions.Add("[:-FP", Resources.R_08__6_);
            emotions.Add("[:SG", Resources.R_08__7_);
            emotions.Add("[8-|", Resources.R_08__8_);
            emotions.Add("[:FP2", Resources.R_08__9_);

            #endregion

            #region Radif 9

            emotions.Add("[:HE", Resources.R_09__1_);
            emotions.Add("[:HO", Resources.R_09__2_);
            emotions.Add("[:-NF", Resources.R_09__3_);
            emotions.Add("[/:/", Resources.R_09__4_);
            emotions.Add("[:silly", Resources.R_09__5_);
            emotions.Add("[:yawn", Resources.R_09__6_);
            emotions.Add("[:-N", Resources.R_09__7_);
            emotions.Add("[:-Y", Resources.R_09__8_);
            emotions.Add("[:witch", Resources.R_09__9_);

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

            emotions.Add("[#OM", Resources.R_10__1_);
            emotions.Add("[(-?", Resources.R_10__2_);
            emotions.Add("[:-\"", Resources.R_10__3_);
            emotions.Add("[(-[", Resources.R_10__4_);
            emotions.Add("[=-D>>", Resources.R_10__5_);
            emotions.Add("[(-SC", Resources.R_10__6_);
            emotions.Add("[:bb", Resources.R_10__7_);
            emotions.Add("[#)", Resources.R_10__8_);
            emotions.Add("[:#Cake", Resources.R_10__9_);
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
            emotions.Add("[::DA", Resources.R_11__1_);
            emotions.Add("[::PP", Resources.R_11__2_);
            emotions.Add("[:CH", Resources.R_11__3_);
            emotions.Add("[:BO", Resources.R_11__4_);
            emotions.Add("[:SH", Resources.R_11__5_);
            emotions.Add("[::PR", Resources.R_11__6_);
            emotions.Add("[-:)_", Resources.R_11__7_);
            emotions.Add("[:-K", Resources.R_11__8_);
            emotions.Add("[:HR ", Resources.R_11__9_);

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
            emotions.Add("[:CL", Resources.R_12__1_);
            emotions.Add("[:BN", Resources.R_12__2_);
            emotions.Add("[(manicure)", Resources.R_12__3_);
            emotions.Add("[:RN", Resources.R_12__4_);
            emotions.Add("[(cheering)", Resources.R_12__5_);
            emotions.Add("[(computer)", Resources.R_12__6_);
            emotions.Add("[(shy)", Resources.R_12__7_);
            emotions.Add("[(guitarist)", Resources.R_12__8_);
            emotions.Add("[(singing)", Resources.R_12__9_);

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
            emotions.Add("[:bdance", Resources.R_13__1_);
            emotions.Add("[:bday", Resources.R_13__2_);
            emotions.Add("[(xmas)", Resources.R_13__3_);
            emotions.Add("[(clap)", Resources.R_13__4_);
            emotions.Add("[:hbd", Resources.R_13__5_);
            emotions.Add("[:hny", Resources.R_13__6_);
            emotions.Add("[(chl)", Resources.R_13__7_);
            emotions.Add("[:swim", Resources.R_13__8_);
            emotions.Add("[(xsnow)", Resources.R_13__9_);

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
            emotions.Add("[(mario)", Resources.R_14__1_);
            emotions.Add("[(cook)", Resources.R_14__2_);
            emotions.Add("[(gig)", Resources.R_14__3_);
            emotions.Add("[(anni)", Resources.R_14__4_);
            emotions.Add("[(h.val)", Resources.R_14__5_);
            emotions.Add("[(bday)", Resources.R_14__6_);
            emotions.Add("[(rainbow)", Resources.R_14__7_);
            emotions.Add("[(hit)", Resources.R_14__8_);
            emotions.Add("[(head)", Resources.R_14__9_);

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
            emotions.Add("[(wow)", Resources.R_15__1_);
            emotions.Add("[(lovebird)", Resources.R_15__2_);
            emotions.Add("[(b.day)", Resources.R_15__3_);
            emotions.Add("[(lol)", Resources.R_15__4_);
            emotions.Add("[(ilu)", Resources.R_15__5_);
            emotions.Add("[(cmptr)", Resources.R_15__6_);
            emotions.Add("[(pengu)", Resources.R_15__7_);
            emotions.Add("[(val)", Resources.R_15__8_);
            emotions.Add("[(kiss)", Resources.R_15__9_);

            #endregion

        }

        public void AddEmotions()
        {
            foreach (string emote in emotions.Keys)
            {
                try
                {
                    while (richTextBox1.Text.Contains(emote))
                    {
                        int ind = richTextBox1.Text.IndexOf(emote);
                        richTextBox1.Select(ind, emote.Length);
                        Clipboard.SetImage((Image)emotions[emote]);
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


    }

}

