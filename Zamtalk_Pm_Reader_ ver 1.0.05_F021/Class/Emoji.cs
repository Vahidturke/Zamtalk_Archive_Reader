using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__ver_1._0._05_F021.ReSourcesAndImage;

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
            emotions.Add("[:)", Resource1.R_01__1_);
            emotions.Add("[:(", Resource1.R_01__2_);
            emotions.Add("[;)", Resource1.R_01__3_);

            emotions.Add("[:D", Resource1.R_01__4_);
            emotions.Add("[:d", Resource1.R_01__4_);

            emotions.Add("[;;)", Resource1.R_01__5_);

            emotions.Add("[:-DD", Resource1.R_01__6_);
            emotions.Add("[:-dd", Resource1.R_01__6_);

            emotions.Add("[>:-D<", Resource1.R_01__7_);
            emotions.Add("[>:-d<", Resource1.R_01__7_);

            emotions.Add("[:ty", Resource1.R_01__8_);

            emotions.Add("[:x", Resource1.R_01__9_);
            emotions.Add("[:X", Resource1.R_01__9_);

            emotions.Add("[:TY", Resource1.R_01__8_);
            emotions.Add("[:Ty", Resource1.R_01__8_);
            emotions.Add("[:tY", Resource1.R_01__8_);

            #endregion

            #region Radif 2

            emotions.Add("[:\">", Resource1.R_02__1_);
            emotions.Add("[:P", Resource1.R_02__2_);
            emotions.Add("[:*", Resource1.R_02__3_);
            emotions.Add("[=((", Resource1.R_02__4_);
            emotions.Add("[:O", Resource1.R_02__5_);
            emotions.Add("[X(", Resource1.R_02__6_);
            emotions.Add("[:->", Resource1.R_02__7_);
            emotions.Add("[:B-)", Resource1.R_02__8_);
            emotions.Add("[:SR", Resource1.R_02__9_);

            #endregion

            #region Radif 3

            emotions.Add("[:-s", Resource1.R_03__1_);
            emotions.Add("[=D>", Resource1.R_03__2_);
            emotions.Add("[:C(", Resource1.R_03__3_);
            emotions.Add("[:-((", Resource1.R_03__4_);
            emotions.Add("[:H)", Resource1.R_03__5_);
            emotions.Add("[:h)", Resource1.R_03__5_);
            emotions.Add("[=))", Resource1.R_03__6_);
            emotions.Add(@"[\:-D/", Resource1.R_03__7_);
            emotions.Add("[:-PP", Resource1.R_03__8_);
            emotions.Add("[(-X", Resource1.R_03__9_);

            #endregion

            #region Radif 4

            emotions.Add("[:fight", Resource1.R_04__1_);
            emotions.Add("[:ST", Resource1.R_04__2_);
            emotions.Add("[#-O", Resource1.R_04__3_);
            emotions.Add("[<:-P", Resource1.R_04__4_);
            emotions.Add("[--X(", Resource1.R_04__5_);
            emotions.Add("[\\;)", Resource1.R_04__6_);
            emotions.Add("[#-ST", Resource1.R_04__7_);
            emotions.Add("[:-)]", Resource1.R_04__8_);
            emotions.Add("[:?", Resource1.R_04__9_);

            #endregion

            #region Radif 5

            emotions.Add("[(-(", Resource1.R_05__1_);
            emotions.Add("[#-BO", Resource1.R_05__2_);
            emotions.Add("[8->", Resource1.R_05__3_);
            emotions.Add("[:BZ", Resource1.R_05__4_);
            emotions.Add("[(MU)", Resource1.R_05__5_);
            emotions.Add("[:-DA", Resource1.R_05__6_);
            emotions.Add("[:-RF", Resource1.R_05__7_);
            emotions.Add("[::))", Resource1.R_05__8_);
            emotions.Add("[:-*)", Resource1.R_05__9_);

            #endregion

            #region Radif 6

            emotions.Add("[:-HK", Resource1.R_06__1_);
            emotions.Add("[:-H", Resource1.R_06__2_);
            emotions.Add("[:Help", Resource1.R_06__3_);
            emotions.Add("[:-??", Resource1.R_06__4_);
            emotions.Add("[:-FD", Resource1.R_06__5_);
            emotions.Add("[(dance)", Resource1.R_06__6_);
            emotions.Add("[#-HH", Resource1.R_06__7_);
            emotions.Add("[:smoking", Resource1.R_06__8_);
            emotions.Add("[~O)", Resource1.R_06__9_);
            #endregion

            #region Radif 7

            emotions.Add("[#:RB", Resource1.R_07__1_);
            emotions.Add("[:-BU", Resource1.R_07__2_);
            emotions.Add("[:-FO", Resource1.R_07__3_);
            emotions.Add("[:-)>-", Resource1.R_07__4_);
            emotions.Add("[<3", Resource1.R_07__5_);
            emotions.Add("[#-NS", Resource1.R_07__6_);
            emotions.Add("[@};-", Resource1.R_07__7_);
            emotions.Add("[:-OM", Resource1.R_07__8_);
            emotions.Add("[:-FL", Resource1.R_07__9_);

            #endregion

            #region Radif 8
            emotions.Add("[:-BD", Resource1.R_08__1_);
            emotions.Add("[(:|", Resource1.R_08__2_);
            emotions.Add("[:-{K", Resource1.R_08__3_);
            emotions.Add("[:SC", Resource1.R_08__4_);
            emotions.Add("[:SB", Resource1.R_08__5_);
            emotions.Add("[:-FP", Resource1.R_08__6_);
            emotions.Add("[:SG", Resource1.R_08__7_);
            emotions.Add("[8-|", Resource1.R_08__8_);
            emotions.Add("[:FP2", Resource1.R_08__9_);

            #endregion

            #region Radif 9

            emotions.Add("[:HE", Resource1.R_09__1_);
            emotions.Add("[:HO", Resource1.R_09__2_);
            emotions.Add("[:-NF", Resource1.R_09__3_);
            emotions.Add("[/:/", Resource1.R_09__4_);
            emotions.Add("[:silly", Resource1.R_09__5_);
            emotions.Add("[:yawn", Resource1.R_09__6_);
            emotions.Add("[:-N", Resource1.R_09__7_);
            emotions.Add("[:-Y", Resource1.R_09__8_);
            emotions.Add("[:witch", Resource1.R_09__9_);

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

            emotions.Add("[#OM", Resource1.R_10__1_);
            emotions.Add("[(-?", Resource1.R_10__2_);
            emotions.Add("[:-\"", Resource1.R_10__3_);
            emotions.Add("[(-[", Resource1.R_10__4_);
            emotions.Add("[=-D>>", Resource1.R_10__5_);
            emotions.Add("[(-SC", Resource1.R_10__6_);
            emotions.Add("[:bb", Resource1.R_10__7_);
            emotions.Add("[#)", Resource1.R_10__8_);
            emotions.Add("[:#Cake", Resource1.R_10__9_);
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
            emotions.Add("[::DA", Resource1.R_11__1_);
            emotions.Add("[::PP", Resource1.R_11__2_);
            emotions.Add("[:CH", Resource1.R_11__3_);
            emotions.Add("[:BO", Resource1.R_11__4_);
            emotions.Add("[:SH", Resource1.R_11__5_);
            emotions.Add("[::PR", Resource1.R_11__6_);
            emotions.Add("[-:)_", Resource1.R_11__7_);
            emotions.Add("[:-K", Resource1.R_11__8_);
            emotions.Add("[:HR ", Resource1.R_11__9_);

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
            emotions.Add("[:CL", Resource1.R_12__1_);
            emotions.Add("[:BN", Resource1.R_12__2_);
            emotions.Add("[(manicure)", Resource1.R_12__3_);
            emotions.Add("[:RN", Resource1.R_12__4_);
            emotions.Add("[(cheering)", Resource1.R_12__5_);
            emotions.Add("[(computer)", Resource1.R_12__6_);
            emotions.Add("[(shy)", Resource1.R_12__7_);
            emotions.Add("[(guitarist)", Resource1.R_12__8_);
            emotions.Add("[(singing)", Resource1.R_12__9_);

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
            emotions.Add("[:bdance", Resource1.R_13__1_);
            emotions.Add("[:bday", Resource1.R_13__2_);
            emotions.Add("[(xmas)", Resource1.R_13__3_);
            emotions.Add("[(clap)", Resource1.R_13__4_);
            emotions.Add("[:hbd", Resource1.R_13__5_);
            emotions.Add("[:hny", Resource1.R_13__6_);
            emotions.Add("[(chl)", Resource1.R_13__7_);
            emotions.Add("[:swim", Resource1.R_13__8_);
            emotions.Add("[(xsnow)", Resource1.R_13__9_);

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
            emotions.Add("[(mario)", Resource1.R_14__1_);
            emotions.Add("[(cook)", Resource1.R_14__2_);
            emotions.Add("[(gig)", Resource1.R_14__3_);
            emotions.Add("[(anni)", Resource1.R_14__4_);
            emotions.Add("[(h.val)", Resource1.R_14__5_);
            emotions.Add("[(bday)", Resource1.R_14__6_);
            emotions.Add("[(rainbow)", Resource1.R_14__7_);
            emotions.Add("[(hit)", Resource1.R_14__8_);
            emotions.Add("[(head)", Resource1.R_14__9_);

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
            emotions.Add("[(wow)", Resource1.R_15__1_);
            emotions.Add("[(lovebird)", Resource1.R_15__2_);
            emotions.Add("[(b.day)", Resource1.R_15__3_);
            emotions.Add("[(lol)", Resource1.R_15__4_);
            emotions.Add("[(ilu)", Resource1.R_15__5_);
            emotions.Add("[(cmptr)", Resource1.R_15__6_);
            emotions.Add("[(pengu)", Resource1.R_15__7_);
            emotions.Add("[(val)", Resource1.R_15__8_);
            emotions.Add("[(kiss)", Resource1.R_15__9_);

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

