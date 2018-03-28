using System;
using System.IO;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاس کپی کننده و تغییر نام دهنده فایل های موقت یا همون تمپ و قابل خواندن کردن پی ام ها با اضافه کردن پسوند تکست
    /// </summary>
    public class CopyDir
    {
        /// <summary>
        /// نام پوشه ای که در آپ دیتا ساخته خواهد شد 
        /// </summary>
        private const string nameFolderAppData = "copyarchive";
        public static string NameFolderAppData => nameFolderAppData;
        /// <summary>
        /// کل عملیات کپی کردن آرشیو با این متد انجام میشود
        /// </summary>
        /// <param name="listBox">لیست باکسی که مسیر های پوشه هایی که انتخاب کردیم و داخلش آرشیو زم هست</param>
        /// <param name="treeView">تری ویو برای نمایش فایل های ارشیو به صورت اکسپلورر</param>
        /// <param name="magasd">مقصد مکانی که میخواهیم پوشه موقت یا تمپ و ... در آنجا ذخیره شود</param>
        public static void StaticCopy(ListBox listBox, TreeView treeView, string magasd)
        {
            PmExplorer p = new PmExplorer();

            TempMakers oTempMakers = new TempMakers();

            magasd = oTempMakers.AppdataFolder(NameFolderAppData);

            foreach (var item in listBox.Items)
            {
                Copy((string)item, magasd, true);
            }

            p.TreeViewexplorer(treeView, magasd);
        }
        /// <summary>
        /// کپی کردن فایل ها و پوشه هایی که داخل پوشه آرشیو انتخاب شده و اضافه کردن پسودن تکست برای باز قابل خواندن کردنش
        /// </summary>
        /// <param name="source">مبدا یا مکان پوشه ای که برای کپی از آن کپی خواهیم گرفت </param>
        /// <param name="target">مقصد یا مکان پوشه ای که میخواهیم آنجا پیستش کنیم</param>
        /// <param name="ren">قابلیت تغییر نام فایل</param>
        public static void Copy(string sourceDirectory, string targetDirectory, bool ren)
        {
            try
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);

                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                CopyAll(diSource, diTarget, ren);
            }
            catch (Exception) { }
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            try
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                CopyAll(diSource, diTarget);

            }
            catch (Exception) { }
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // هر فایل را در دایرکتوری جدید کپی کنید.     
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // کپی هر زیر شاخه با استفاده از بازگشت.  
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        /// <summary>
        /// کپی کردن فایل ها و پوشه هایی که داخل پوشه آرشیو انتخاب شده و اضافه کردن پسودن تکست برای باز قابل خواندن کردنش
        /// </summary>
        /// <param name="source">مبدا یا مکان پوشه ای که برای کپی از آن کپی خواهیم گرفت </param>
        /// <param name="target">مقصد یا مکان پوشه ای که میخواهیم آنجا پیستش کنیم</param>
        /// <param name="ren">قابلیت تغییر نام فایل</param>
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target, bool ren)
        {
            Directory.CreateDirectory(target.FullName);
            if (ren)
            {
                // هر فایل را در دایرکتوری جدید کپی کنید.     
                foreach (FileInfo fi in source.GetFiles())
                {
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name + ".txt"), ren);
                }
            }
            // کپی هر زیر شاخه با استفاده از بازگشت.  
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir, ren);
            }

        }


    }

}