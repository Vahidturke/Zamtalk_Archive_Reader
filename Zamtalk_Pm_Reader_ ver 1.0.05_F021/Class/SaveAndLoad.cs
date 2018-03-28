using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Zamtalk_Pm_Reader__vr_1._0._0._0
{
    public class SaveAndLoad
    {
        public void RemoveDublicValueListbox(ListBox listBox)
        {
            List<object> items = new List<object>();
            List<object> duplicateItems = new List<object>();


            for (int i = listBox.Items.Count - 1; i >= 0; i--)
            {
                object item = listBox.Items[i];

                if (!items.Contains(item))
                    items.Add(item);
                else
                {
                    duplicateItems.Add(item);
                    listBox.Items.RemoveAt(i);
                }
            }
        }
        public void SaveData(ListBox listBox, string filed)
        {
            TempMakers oTempMakers = new TempMakers();

            string path = oTempMakers.AppDataFile("copyarchive.txt");

            try
            {
                StreamWriter SaveFile = new StreamWriter(path);

                // SaveFile.WriteLine(filed);

                foreach (var item in listBox.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            MessageBox.Show("Save Successfully");
        }
        public void LoadData(ListBox listBox, string pathtxtfile)
        {
            TempMakers oTempMakers = new TempMakers();

            string path = oTempMakers.AppDataFile("copyarchive.txt");

            try
            {
                StreamReader LoadFile = new StreamReader(path);

                string[] allLines = File.ReadAllLines(path);

                listBox.Items.Clear();

                listBox.Items.AddRange(allLines);

                RemoveDublicValueListbox(listBox);

                LoadFile.Close();
            }

            catch (Exception ex)
            {

                ex.ToString();
            }

            MessageBox.Show("Load Successfully");
        }
        public void LoadData_BedoneMsg(ListBox listBox, string pathtxtfile)
        {
            TempMakers oTempMakers = new TempMakers();

            string path = oTempMakers.AppDataFile("copyarchive.txt");

            try
            {
                StreamReader LoadFile = new StreamReader(path);

                string[] allLines = File.ReadAllLines(path);

                listBox.Items.Clear();

                listBox.Items.AddRange(allLines);

                RemoveDublicValueListbox(listBox);

                LoadFile.Close();
            }

            catch (Exception ex)
            {

                ex.ToString();
            }

        }

    }
}
