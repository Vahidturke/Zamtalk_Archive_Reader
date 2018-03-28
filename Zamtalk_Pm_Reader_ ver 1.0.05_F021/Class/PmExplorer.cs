using System.IO;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاس نمایش فایل های مسیرهای اضافه شده برای باز کردن آرشیو
    /// </summary>
    public class PmExplorer : IPmExplorer
    {

        /// <summary>
        /// اضافه کردن ایتم های انتخاب شده به  لیست باکس .داری یک ورودی .و برای خواندن مسیر های آرشیو به کار خواهد رفت
        /// </summary>
        /// <param name="mylb">ورودی لیست باکس</param>
        public void AddItem(ListBox mylb)
        {
            FolderBrowserDialog _FolderBrowserDialog = new FolderBrowserDialog();

            _FolderBrowserDialog.ShowDialog();

            mylb.Items.Add(_FolderBrowserDialog.SelectedPath);
        }

        /// <summary>
        /// حذف ایتم یا مورد انتخاب شده از لیست باکس 
        /// </summary>
        /// <param name="listbox">لیست باکسی که عمل روی آن اجرا خواهد شد</param>
        public void DeletedSelectedItems(ListBox listbox)
        {
            object selecteditem = listbox.SelectedItem;

            if (listbox.SelectedItem != null)
            {
                listbox.Items.Remove(selecteditem);
            }
            else
            {
                MessageBox.Show("Please Select one Items.");
            }
        }

        /// <summary>
        /// پاک کردن تمام موارد داخل لیست باکس
        /// </summary>
        /// <param name="listbox"></param>
        public void ListboxClearAll(ListBox listbox) => listbox.Items.Clear();

        /// <summary>
        /// متدی دارای 2 ورودی برای نمایش آرشیو در تری ویو
        /// </summary>
        /// <param name="treeView1">تری ویو </param>
        /// <param name="path">مسیر پوشه هایی در تری ویو نمایش داده خواهند شد</param>

        public void TreeViewexplorer(TreeView treeView1, string path) // populate treeview
    => ListDirectory(treeView1, path);

        /// <summary>
        /// آیتم هایی که به لیست باکس وارده شده را در تری ویو اضافه کن و نمایش بده
        /// </summary>
        /// <param name="treeView">یک کنترل تری ویو </param>
        /// <param name="listBox">یک کنترلر لیست باکس</param>
        public void ListBoxMoveToTreeView(TreeView treeView, ListBox listBox)
        {
            foreach (var item in listBox.Items)
            {
                TreeViewexplorer(treeView, item.ToString());
            }

            foreach (var item in listBox.Items)
            {
                TreeViewexplorer(treeView, item.ToString());
            }
        }

        #region Encapsol

        private void ListDirectory(TreeView treeView1, string dir)
        {
            //  treeView1.Nodes.Clear();
            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(dir);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

        #endregion

    }
}
