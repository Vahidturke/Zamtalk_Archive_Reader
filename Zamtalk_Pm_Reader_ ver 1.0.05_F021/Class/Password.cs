using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class Password : IPassword
    {
        private List<string> listusername = new List<string>();
        /// <summary>
        /// لیستی یرای ذخیره نام آیدی ها 
        /// </summary>
        public List<string> Listusername { get => listusername; set => listusername = value; }

        private List<string> listPassword = new List<string>();
        /// <summary>
        /// لیستی برای ذخیره پسورد آیدی ها
        /// </summary>
        public List<string> ListPassword { get => listPassword; set => listPassword = value; }

        /// <summary>
        /// مسیر ریجستری زمتالک در ریجستری ویندوز
        /// </summary>
        private const string Regkeyzam = @"software\zamtalk";


        private RegistryKey zamReg;
        /// <summary>
        /// لایه بیرونی کلید ریجستری زم
        /// </summary>
        public RegistryKey ZamReg { get => zamReg; set => zamReg = value; }

        private RegistryKey zamReg2;
        /// <summary>
        /// لایه داخلی کلید ریحستری زم
        /// </summary>
        public RegistryKey ZamReg2 { get => zamReg2; set => zamReg2 = value; }

        private ListViewItem lsVItem;
        /// <summary>
        /// یک لیست باکس که کل کارها رو داخل این انجام خواهیم داد
        /// </summary>
        public ListViewItem LsVItem { get => lsVItem; set => lsVItem = value; }

        /// <summary>
        /// ساختار اولیه لیست باکس و ردیف و ستون هاش 
        /// </summary>
        /// <param name="Lv1">لیست باکس مورد نظر</param>
        public void AddColumns(ListView Lv1)
        {
            Lv1.View = View.Details;
            Lv1.Columns.Add("Name", 100);
            Lv1.Columns.Add("Password", 150);
        }

        /// <summary>
        /// تبدیل کننده هگز به استرینک یا همون متن معمولی
        /// </summary>
        /// <param name="hex">متن هگزه مورد نظر که به متن تبدیل خواهد شد.</param>
        /// <returns></returns>
        public string HexAsciiConvert(string hex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= hex.Length - 2; i += 2)

            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hex.Substring(i, 2),

                System.Globalization.NumberStyles.HexNumber))));
            }

            return sb.ToString();
        }

        /// <summary>
        /// چک باکس برای نمایش و مخفی نشان دادن پسورد همان ستاره دار کردن پسورد موقعه انتخاب کردن
        /// </summary>
        /// <param name="checkBox1">یک چک باکس</param>
        /// <param name="maskedTextBox1">یک ماسک تکست باکس</param>
        /// <param name="TXT_PW">یک تکست باکس زیر ماسک تکست باکس</param>
        public void Pwshowmask(CheckBox checkBox1, MaskedTextBox maskedTextBox1, TextBox TXT_PW)
        {
            if (!checkBox1.Checked)
            {
                TXT_PW.Visible = false;
                maskedTextBox1.Visible = true;
            }
            else
            {
                TXT_PW.Visible = true;
                maskedTextBox1.Visible = false;
            }
        }

        /// <summary>
        /// نمایش دهنده همه آیدی ها با پسورد هگز سیو شده در مسیر ریجستری زم تالک 
        /// </summary>
        /// <param name="listView1"></param>
        public void ShowAllIDZamtalk(ListView listView1)
        {
            ZamReg = Registry.CurrentUser.OpenSubKey(Regkeyzam);

            foreach (string username in ZamReg.GetSubKeyNames())
            {
                LsVItem = listView1.Items.Add(username);

                ZamReg2 = Registry.CurrentUser.OpenSubKey(name: $"{Regkeyzam}\\{username}");

                foreach (string password in ZamReg2.GetSubKeyNames())
                {

                    // add once again one row to column A and B
                    string p = (string)ZamReg2.GetValue("Password");

                    ListPassword.Add(p);

                    LsVItem.SubItems.Add(p);

                }


            }
        }

        /// <summary>
        /// نمایش آیدی و پسورد  گزینه انتخاب شده
        /// </summary>
        /// <param name="listView1">لیست باکس</param>
        /// <param name="lblid">لیبیل آیدی</param>
        /// <param name="lblpw">لیبیل پسورد</param>
        public void ShowPassword(ListView listView1, Label lblid, TextBox lblpw)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                lblid.Text = item.SubItems[0].Text;
                lblpw.Text = item.SubItems[1].Text;

                if (lblpw.Text != null)
                {
                    lblpw.Text = HexAsciiConvert(item.SubItems[1].Text);
                }
            }
            else
            {
                lblid.Text = string.Empty;
                lblpw.Text = string.Empty;
            }

        }
    }
}
