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
        /// <summary>
        /// مسیر ذخیره فایل تکست آدرس پوشه موقت
        /// </summary>
        public static string FullFolderPathRequset(string pth, string foldername) => CheckDir(pth + "\\" + foldername);
        public static string FullFilePathRequset(string path, string Filename) => Checkfile(path + "\\" + Filename);

        public static string ZamArPath
        {
            get
            {
                string folderBase = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return (folderBase + "\\" + "ZamTalkMessenger");
            }
        }



        public static string AppdataFolder(string foldername)
        {
            string folderBase = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            return CheckDir(folderBase + "\\" + foldername);
        }
        public static string AppDataFile(string Filename)
        {
            string folderBase = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Checkfile(folderBase + "\\" + Filename);
        }
        private static string CheckDir(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir;
        }
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