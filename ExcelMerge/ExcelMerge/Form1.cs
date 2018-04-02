using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Spire.Xls;




namespace ExcelMerge
{
    public partial class Form1 : Form
    {
        string[] filename;
        string[] arrAllFiles=new string[]{};
        int count = Properties.Settings.Default.count;
       


        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            listbox.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < listbox.Items.Count; i++)
                listbox.SetSelected(i, true);
           
            //add_listbox.SelectionMode = //back to what you want
        }

       
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void button10_Click(object sender, EventArgs e)
        {
            while (listbox.SelectedItems.Count > 0)
            {
                listbox.Items.Remove(listbox.SelectedItems[0]);
            }

        }
       
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.xls*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            string path = Directory.GetCurrentDirectory();
            //choofdlog.InitialDirectory = path; //
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                arrAllFiles = choofdlog.FileNames;
                filename = choofdlog.SafeFileNames;
                for (int i = 0; i < arrAllFiles.Length;i++ )
                {
                    listbox.Items.Add(filename[i]);
                }
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.count++;
            Properties.Settings.Default.Save();
            Workbook newbook = new Workbook();
            newbook.Version = ExcelVersion.Version2010;
            newbook.Worksheets.Clear();

            Workbook tempbook = new Workbook();
            List<string> excelFiles = new List<string>();
            for (var i = 0; i < listbox.SelectedItems.Count; i++)
            {
                excelFiles.Add(filename[i]);

            }
            if (listbox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Not selected item");
            }
            else
            {
                for (int i = 0; i < excelFiles.Count; i++)
                {
                    tempbook.LoadFromFile(excelFiles[i]);
                    foreach (Worksheet sheet in tempbook.Worksheets)
                    {

                        newbook.Worksheets.AddCopy(sheet);
                    }

                }

                newbook.SaveToFile(count + "result1.xlsx", ExcelVersion.Version2010);
                System.Diagnostics.Process.Start(count + "result1.xlsx");
            }
        }
            

        private void Delete_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < arrAllFiles.Length; i++)
            {
                File.Delete(arrAllFiles[i]);
            }
            
            MessageBox.Show("Files deleted");
            listbox.Items.Clear();
        }


    }
}
