using System;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class Finder
    {

        #region Motagayerha


        private const string RTF_StartTag = @"{\rtf1\ansi\ \rtlch ";
        private const string RTF_FontUsername = @"{\f1\fonttbl{\f1\fcharset0 Tahoma;}{\f2\fcharset0 Microsoft Sans Serif ;}} ";
        private const string RTF_ColorFaw = @" {\colortbl; ";

        public const string RTFStart_Bold = @" \b ";
        public const string RTFStart_italic = @" \i ";
        private const string RTFEnd_italic = @" \i0 ";
        private const string RTFStart_UnderLine = @" \ul ";
        private const string RTFEnd_UnderLine = @" \ul0 ";
        public const string RTFEnd_Bold = @" \b0";

        public const string RTF_fontSizeID = @" \fs20 ";
        public const string RTF_FontSizePm_Smal = @" \fs15 ";
        public const string RTF_FontSizePm_Normal = @" \fs25 ";
        public const string RTF_FontSizePm_Larg = @" \fs35 ";

        public const string ZamBold = @"[b]";
        public const string ZamItalic = @"[i]";
        public const string ZamUnLine = @"[ul]";
        public const string ZamC = @"[c";

        public const string zamFSize1 = @"[s10]";
        public const string zamFSize3 = @"[s18]";


        public const string RTFStart_color1 = @" \cf1 ";
        public const string RTFStart_color2 = @" \cf2 ";
        public const string RTFStart_font1 = @" \f0 ";
        public const string RTFStart_font2 = @" \f1 ";
        private const string RTF_newline = "\\par ";
        private const string RTF_Endtext = @" } ";

        private const string Aval = "[b][cFF7FFF][f\"\"Tahoma\"\"][s08]";
        private const string dovom = "\"[b][cFF7FFF][f\"\"Tahoma\"\"][s08]";
        public static string asd = @"[f""Microsoft Sans Serif""][s10]";



        #endregion

        #region Method ha  

        /// <summary>
        /// اینر زدن به خط جدید
        /// </summary>
        /// <param name="richTextBox3"></param>
        /// <param name="items"></param>
        public void NewlineAndAddToListBox(RichTextBox richTextBox3, ListBox.ObjectCollection items)
        {
            FRM_Main fm = new FRM_Main();

            string c = fm.textBox1.Text;

            richTextBox3.Text = richTextBox3.Text.Replace(c, RTF_newline + Environment.NewLine);

            foreach (string item in richTextBox3.Lines)
            {
                items.Add(item);
            }
        }
        public string PM(string listBox1)
        {
            return listBox1.Replace(listBox1.Substring(0, listBox1.IndexOf(@")") + 1), " ");

        }
        public string UserName(string listBox1)
        {
            return listBox1.Substring(0, listBox1.IndexOf(@")") + 1);

        }
        ConvertColorFont oConvertColorFont = new ConvertColorFont();
        public string FColorEnd(string AllPm)
        {
            return oConvertColorFont.ConvertZamtalkColorToRTFColor(AllPm.Substring(AllPm.LastIndexOf("[c"), 9));
        }
        public string FColorstart(string AllPm)
        {
            return oConvertColorFont.ConvertZamtalkColorToRTFColor(AllPm.Substring(AllPm.IndexOf("[c"), 9));
        }
        public string EditID(string mytext)
        {
            var a = UserName(mytext);
            a = a.Remove(0, 30);

            return a;
        }
        public string FixID(string all)
        {
            var a = UserName(all);
            a = EditID(all);
            return a;
        }
        public string Editpm(string mytext)
        {
            var a = PM(mytext);
            a = a.Remove(0, 27);

            return a;

        }
        public string PmRemoveTag(TextBox tb3)
        {
            TextBox t = new TextBox();
            t = tb3;
            if (tb3.Text.Contains(ZamC))
            {
                tb3.Text = tb3.Text.Remove(tb3.Text.IndexOf(ZamC), 9);
                tb3.Text = tb3.Text.Replace(ZamBold, RTFStart_Bold);
            }
            if (tb3.Text.Contains(ZamBold))
            {
                tb3.Text = tb3.Text.Replace(ZamBold, RTFStart_Bold);

            }
            if (tb3.Text.Contains(ZamItalic))
            {
                tb3.Text = tb3.Text.Replace(ZamItalic, RTFStart_italic);

            }
            if (tb3.Text.Contains(ZamUnLine))
            {
                tb3.Text = tb3.Text.Replace(ZamUnLine, RTFStart_UnderLine);

            }
            if (tb3.Text.Contains("[f\"\"Microsoft Sans Serif\"\"]"))
            {
                tb3.Text = tb3.Text.Replace("[f\"\"Microsoft Sans Serif\"\"]", RTFStart_color2);

            }

            if (tb3.Text.Contains(zamFSize1))
            {
                tb3.Text = tb3.Text.Replace(zamFSize1, RTFStart_font2);

            }
            if (tb3.Text.Contains(zamFSize3))
            {
                tb3.Text = tb3.Text.Replace(zamFSize3, RTFStart_font2 + RTF_FontSizePm_Larg);

            }
            return tb3.Text;

        }
        public string Finish(ListBox alls, TextBox tb)
        {
            string d = alls.SelectedItem.ToString();
            var all = string.Concat(
                RTF_StartTag,
                RTF_FontUsername,
                RTF_ColorFaw,
                FColorstart(alls.SelectedItem.ToString()),
                @";",
                FColorEnd(d),
                @";}",
                RTFStart_font1,
                RTF_fontSizeID,
                RTFStart_Bold,
                RTFStart_color1,
                FixID(alls.SelectedItem.ToString()),
                RTFEnd_Bold,
                RTFStart_color2,
                PmRemoveTag(tb));
            return all;

        }
        #endregion
    }
}
