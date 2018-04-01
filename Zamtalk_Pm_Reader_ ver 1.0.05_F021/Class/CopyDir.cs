using System;
using System.IO;
using System.Windows.Forms;
using Zamtalk_Pm_Reader__vr_1._0._0._0;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاس کپی کننده و تغییر نام دهنده فایل های موقت یا همون تمپ و قابل خواندن کردن پی ام ها با اضافه کردن پسوند تکست
    /// </summary>
    public class CopyDir
    {

        public static void StaticCopy(ListBox listBox, TreeView treeView, string magasd)
        {
            PmExplorer p = new PmExplorer();
            magasd = TempMakers.AppdataFolder("copyarchive");

            foreach (var item in listBox.Items)
            {
                CopyDir.Copy((string)item, magasd, true);
            }
            p.TreeViewexplorer(treeView, magasd);
        }
        internal static void Copy(string sourceDirectory, string targetDirectory, bool ren)
        {
            try
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                CopyAll(diSource, diTarget, ren);

            }
            catch (Exception)
            { }
        }
        internal static void Copy(string sourceDirectory, string targetDirectory)
        {
            try
            {
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

                CopyAll(diSource, diTarget);

            }
            catch { }
        }
        internal static void CopyAll(DirectoryInfo source, DirectoryInfo target)
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
        internal static void CopyAll(DirectoryInfo source, DirectoryInfo target, bool ren)
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






 




