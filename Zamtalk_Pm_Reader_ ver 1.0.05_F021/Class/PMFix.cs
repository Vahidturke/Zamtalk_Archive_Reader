using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class PMFix
    {
        public string strlbl;
        public string strtextbox;
        public string strrich;
        public PMFix(string strtxt)
        {
            this.strtextbox = strtxt;
        }

        #region پترن ها

        /// <summary>
        /// متغییری برای ذخیره گام به گام متن مورد نظر
        /// </summary>
        private string Swap { get; set; }
        /// <summary>
        /// قالب ریگولار برای فونت ایتالیک 
        /// </summary>
        public string Patern_I
        {
            get
            {
                return "(\\[[i]\\])?|";
            }
        }
        private string Patern_Bold
        {
            get
            {
                return "(\\[[b]\\])|";
            }
        }
        private string Patern_Font1
        {
            get
            {
                return "(\\[f\"\"Tahoma\"\"\\])|";
            }
        }
        private string Patern_Size
        {
            get
            {
                return "(\\[c[a-fA-F_0-9]{6,7}\\])|";
            }
        }

        /// <summary>
        /// قالب ریگولار برای نیو لاین کردن یا همون زدن اینتر برای رفتن به خط پایینی
        /// </summary>
        public string Patern_Enter
        {
            get
            {
                return @",";
            }
        }

        /// <summary>
        /// قالب ریگولار برای فونت بعد از تایم که فوت طولانی است
        /// </summary>
        public string Patren_AfterTime2
        {
            get
            {
                return "([\\[f\"\"Microsoft Sans Serif\"\"\\]]{20,27})|&";
            }
        }

        /// <summary>
        /// قالب ریگولار برای حذف بولد بودن فونت رنگ فونت اندازه فونت 
        /// </summary>
        public string Patren_Font_Size
        {
            get
            {
                return "(\\[s[0-9]{1,2}\\])|"; ;
            }
        }

        /// <summary>
        /// یک آبجکت از کلاس ریگولار اسپریشن برای اعمال عمل قالب بندی و جایگذاری 
        /// </summary>
        private Regex ORegx { get; set; }

        #endregion

        /// <summary>
        /// متد اصلی برای اجرا
        /// </summary>
        /// <returns></returns>
        public string GetPM_Fixed()
        {
            try
            {
                strlbl = ".متن با موفقیت اصلاح شد";

                StreamReader sr = new StreamReader(strtextbox, ASCIIEncoding.Unicode);
                Swap = sr.ReadToEnd();
                strrich = Swap;
                sr.Close();

                ORegx = new Regex(Patren_Font_Size);
                Swap = ORegx.Replace(Swap, "");

                ORegx = new Regex(Patern_Enter);
                Swap = ORegx.Replace(Swap, Environment.NewLine + "");

                ORegx = new Regex(Patern_I);
                Swap = ORegx.Replace(Swap, "");

                ORegx = new Regex(Patren_AfterTime2);
                Swap = ORegx.Replace(Swap, "");

                ORegx = new Regex(Patern_Bold);
                Swap = ORegx.Replace(Swap, "");

                ORegx = new Regex(Patern_Font1);
                Swap = ORegx.Replace(Swap, "");

                ORegx = new Regex(Patern_Size);
                Swap = ORegx.Replace(Swap, "");

            }
            catch (Exception)
            {
                strlbl = ".لطفا فایلی برای باز کردن انتخاب کنید";
                //MessageBox.Show(".لطفا فایلی برای باز کردن انتخاب کنید");
            }

            return Swap;

        }
        public void SetPM_Fixed(string value)
        {
            SetPM_Fixed(value);
        }

    }

}
