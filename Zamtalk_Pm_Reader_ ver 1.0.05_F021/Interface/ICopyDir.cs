using System.IO;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public interface ICopyDir
    {
        string NameFolderAppData { get; }

        void Copy(string sourceDirectory, string targetDirectory);
        void Copy(string sourceDirectory, string targetDirectory, bool ren);
        void CopyAll(DirectoryInfo source, DirectoryInfo target);
        void CopyAll(DirectoryInfo source, DirectoryInfo target, bool ren);
        void StaticCopy(ListBox listBox, TreeView treeView, string magasd);
    }
}