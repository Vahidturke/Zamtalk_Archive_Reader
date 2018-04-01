using System.IO;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    /// <summary>
    /// کلاس نمایش فایل های مسیرهای اضافه شده برای باز کردن آرشیو
    /// </summary>
    internal class PmExplorer
    {
        public PmExplorer()
        {
        }
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

        public void AddItem(ListBox listbox)
        {
            var f = new FolderBrowserDialog(); f.ShowDialog();

            listbox.Items.Add(f.SelectedPath);

        }

        public void ListboxClearAll(ListBox listbox)
        {
            listbox.Items.Clear();
        }


        public void ListBoxMoveToTreeView(TreeView treeView, ListBox listBox)
        {

            foreach (var item in listBox.Items)
            {
                TreeViewexplorer(treeView, item.ToString());
            }

        }

        /// <summary>
        /// متدی دارای 2 ورودی برای نمایش آرشیو در تری ویو
        /// </summary>
        /// <param name="treeView1">تری ویو </param>
        /// <param name="path">مسیر پوشه هایی در تری ویو نمایش داده خواهند شد</param>
        internal void TreeViewexplorer(TreeView treeView1, string path) // populate treeview
        {
            ListDirectory(treeView1, path);
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


