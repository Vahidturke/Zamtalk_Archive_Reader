using System;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class Finder
    {

        #region Motagayerha

        private const string StartRTFTag = @"{\rtf1\ansi\ \rtlch ";
        private const string FontUsername = @"{\f1\fonttbl{\f1\fcharset0 Tahoma;}{\f2\fcharset0 Microsoft Sans Serif ;}} ";
        private const string ColorFaw = @"{\colortbl; ";
        public const string UseBold = @"\b ";
        public const string useitalic = @"\i ";
        private const string unuseitalic = @"\i0 ";
        private const string useUnderLine = @"\ul ";
        private const string unuseUnderLine = @"\ul0 ";
        public const string UnUseBold = @"\b0";
        public const string fontSizeID = @"\fs20 ";
        public const string FontSizePm_Smal = @"\fs15 ";
        public const string FontSizePm_Normal = @"\fs25 ";
        public const string FontSizePm_Larg = @"\fs35 ";


        public const string Usecolor1 = @"\cf1 ";
        public const string usecolor2 = @"\cf2 ";
        public const string usefont1 = @"\f0 ";
        public const string usefont2 = @"\f1 ";
        private const string newline = @"\par ";
        private const string Endtext = @"} ";

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
            var c = fm.textBox1.Text;

            //var c = "\",\"";
            var d = " \\par ";
            // var d = "\\line";
            richTextBox3.Text = richTextBox3.Text.Replace(c, d + Environment.NewLine);
            foreach (var item in richTextBox3.Lines)
            {
                items.Add(item);
            }
        }
        public string PM(string listBox1)
        {
            var a = listBox1.Substring(0, listBox1.IndexOf(@")") + 1);
            var d = listBox1.Replace(a, "");
            return d;

        }
        public string UserName(string listBox1)
        {
            var a = listBox1.Substring(0, listBox1.IndexOf(@")") + 1);
            return a;

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
            if (tb3.Text.Contains(@"[c"))
            {
                tb3.Text = tb3.Text.Remove(tb3.Text.IndexOf(@"[c"), 9);
                tb3.Text = tb3.Text.Replace(@"[b]", @"\b");
            }
            if (tb3.Text.Contains(@"[b]"))
            {
                tb3.Text = tb3.Text.Replace(@"[b]", @"\b");

            }
            if (tb3.Text.Contains(@"[i]"))
            {
                tb3.Text = tb3.Text.Replace(@"[i]", @"\i");

            }
            if (tb3.Text.Contains(@"[ul]"))
            {
                tb3.Text = tb3.Text.Replace(@"[ul]", @"\ul");

            }
            if (tb3.Text.Contains("[f\"\"Microsoft Sans Serif\"\"]"))
            {
                tb3.Text = tb3.Text.Replace("[f\"\"Microsoft Sans Serif\"\"]", @"\cf2 ");

            }
            if (tb3.Text.Contains(@"[s10]"))
            {
                tb3.Text = tb3.Text.Replace(@"[s10]", usefont2);

            }
            if (tb3.Text.Contains(@"[s18]"))
            {
                tb3.Text = tb3.Text.Replace(@"[s18]", usefont2 + FontSizePm_Larg);

            }
            return tb3.Text;

        }
        public string Finish(ListBox alls, TextBox tb)
        {
            string d = alls.SelectedItem.ToString();
            var all = string.Concat(
                StartRTFTag,
                FontUsername,
                ColorFaw,
                FColorstart(alls.SelectedItem.ToString()),
                @";",
                FColorEnd(d),
                @";}",
                usefont1,
                fontSizeID,
                UseBold,
                Usecolor1,
                FixID(alls.SelectedItem.ToString()),
                UnUseBold,
                usecolor2,
                PmRemoveTag(tb));
            return all;

        }
        #endregion
    }
}
