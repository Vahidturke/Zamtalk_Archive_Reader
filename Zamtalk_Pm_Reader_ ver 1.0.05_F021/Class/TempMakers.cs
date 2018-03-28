using System;
using System.IO;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاس که برای ساخت پوشه و فایل تمپ یا همون حافظه موقت برنامه قرار داده بودیم رو میسازه 
    /// </summary>
    public class TempMakers
    {
        public TempMakers()
        {
        }

        //مسیر ذخیره فایل تکست آدرس پوشه موقت

        /// <summary>
        ///  گرفتن کامل میسر پوشه ای که میخواهیم درست کنیم و نام پوشه ای که قرار است ساخته شود
        /// </summary>
        /// <param name="path">میسر پوشه ای که میخواهیم درست کنیم</param>
        /// <param name="foldername">نام پوشه ای که قرار است ساخته شود</param>
        /// <returns></returns>
        public static string FullFolderPathRequset(string path, string foldername) => CheckDir(path + "\\" + foldername);

        /// <summary>
        /// گرفتن مسبر و نام فایل مورد نظری که خواهد ساخت
        /// </summary>
        /// <param name="path">مسیر مورد نظر برای ساخت فایل</param>
        /// <param name="Filename">نام فایل مورد نظر</param>
        /// <returns></returns>
        public static string FullFilePathRequset(string path, string Filename) => Checkfile(path + "\\" + Filename);

        /// <summary>
        /// در پوشه آپ دیتا مکان پیش فرض داده شده شما فقط نام پوشه رو وارد کن چک میکنم اگه آن پوشه نبود میسازم
        /// </summary>
        /// <param name="foldername">نام پوشه ای که قرار است ساخته شود</param>
        /// <returns></returns>
        public string AppdataFolder(string foldername)
            => CheckDir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + foldername);

        /// <summary>
        /// در پوشه آپ دیتا مکان پیش فرض داده شده شما فقط نام فایل رو وارد کن چک میکنم اگه آن فایل نبود میسازم
        /// </summary>
        /// <param name="Filename">نام فایل مورد نظر</param>
        /// <returns></returns>
        public string AppDataFile(string Filename)
            => Checkfile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Filename);

        /// <summary>
        /// چک کردن مسیر وبرگردان وضعیت بود و نبود پوشه مورد نظر که از ورودی میگیرد
        /// </summary>
        /// <param name="dir">نام پوشه یا همان مسیر  مورد نظر برای چک کردن</param>
        /// <returns></returns>
        private static string CheckDir(string dir)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            return dir;
        }

        /// <summary>
        /// چک کردن فایل مورد نظر در مسیر خاص وبرگردان وضعیت بود و نبود فایل مورد نظر که از ورودی میگیرد
        /// </summary>
        /// <param name="dir">نام فایل یا همان مسیرفایل  مورد نظر برای چک کردن</param>
        /// <returns></returns>
        private static string Checkfile(string file)
        {
            if (!File.Exists(file))
            {
                File.CreateText(file);
            }
            return file;
        }

    }
}