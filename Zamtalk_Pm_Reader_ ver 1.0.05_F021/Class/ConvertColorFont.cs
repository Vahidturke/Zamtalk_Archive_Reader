using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاسی برای تبدیل کردن رنگ به هگزا و متن و امثال این موضوع ها
    /// </summary>
    public class ConvertColorFont
    {

        /// <summary>
        /// یک رشته هگز به یک شیء رنگی دات نت را تبدیل کنید.
        /// </summary>
        /// <param name="hexColor">یک رشته شش ضلعی:"FFFFFF", "#000000""</param>
        public Color HexStringToColor(string hexColor)
        {
            string hc = ExtractHexDigits(hexColor);
            if (hc.Length != 6)
            {
                // شما می توانید انتخاب کنید که آیا یک استثنا را پرتاب کنید
                //throw new ArgumentException("شش رنگ رنگ دقیقا 6 رقمی نیست.");

                return Color.Empty;
            }
            string r = hc.Substring(0, 2);
            string g = hc.Substring(2, 2);
            string b = hc.Substring(4, 2);
            Color color;
            try
            {
                int ri
                    = Int32.Parse(r, System.Globalization.NumberStyles.HexNumber);
                int gi
                    = Int32.Parse(g, System.Globalization.NumberStyles.HexNumber);
                int bi
                    = Int32.Parse(b, System.Globalization.NumberStyles.HexNumber);
                color = Color.FromArgb(ri, gi, bi);
            }
            catch
            {
                //شما می توانید انتخاب کنید که آیا یک استثنا را پرتاب کنید
                //پرتاب اشکال جدید Argument ("تبدیل نتواند");
                return Color.Empty;
            }
            return color;
        }

        /// <summary>
        /// فقط یک رقم شش رقمی از یک رشته را استخراج کنید.
        /// </summary>
        public string ExtractHexDigits(string input)
        {
            // هر کاراکتری را که رقمی نیست (مانند #) حذف کنید
            Regex isHexDigit =
                new Regex("[abcdefABCDEF\\d]+", RegexOptions.Compiled);
            string newnum = "";
            foreach (char c in input)
            {
                if (isHexDigit.IsMatch(c.ToString()))
                    newnum += c.ToString();
            }
            return newnum;
        }

        /// <summary>
        /// تبدیل کننده رنگ پی ام زمتالک به اسکریپ آر تی اف
        /// </summary>
        /// <param name="ZamtalkColorCode">ورودی کد رنگ زم</param>
        /// <returns></returns>
        public string ConvertZamtalkColorToRTFColor(string ZamtalkColorCode)
        {
            ZamtalkColorCode = ZamtalkColorCode.Replace("[c", "[#");
            Color swap = HexStringToColor(ZamtalkColorCode);

            return $"{@"\red"}{swap.R}{@"\green"}{swap.G}{@"\blue"}{swap.B}";
        }

    }
}
