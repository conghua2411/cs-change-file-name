using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace change_file_name_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // handle button search folder
        private void btn_searchDir_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                tb_dir.Text = fbd.SelectedPath;
            }
        }

        // handle random charater or number.
        private static Random rnd = new Random();

        private string randomNameFileType(string file, int length, bool hasChar)
        {
            string newName = "";

            if (hasChar)
            {
                for (int i = 0; i < length; i++)
                {
                    if (rnd.Next(2) == 0)
                    {
                        newName += ((char)(rnd.Next(26) + 97)).ToString();
                    }
                    else
                    {
                        newName += rnd.Next(10).ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    newName += rnd.Next(10).ToString();
                }

            }

            string fileName = file.Substring(0,file.IndexOf("."));
            string fileType = file.Substring(file.LastIndexOf("."));

            return newName + fileType;
        }

        // function change name in single folder
        private void changeNameInFolder(string folderDir, int length, bool hasChar)
        {
            string[] files = Directory.GetFiles(folderDir);

            string tmpName, newName = "";

            for (int i = 0; i < files.Length; i++)
			{
                newName = folderDir + "\\" + randomNameFileType(files[i].Substring(files[i].LastIndexOf("\\")), length, hasChar);
                
                if (!File.Exists(newName))
                {
                    System.IO.File.Move(files[i], newName);
                }
                else
                {
                    tmpName = newName.Substring(newName.LastIndexOf("\\") +1);

                    int j = 1;

                    tmpName = tmpName.Insert(tmpName.LastIndexOf("."), " (0)");

                    do
                    {
                        tmpName = tmpName.Replace("(" + (j - 1).ToString() + ")", "(" + j.ToString() + ")");
                        newName = folderDir + "\\" + tmpName;

                        j++;

                    } while (File.Exists(newName));

                    System.IO.File.Move(files[i], newName);
                }
            }
        }

        // function change name in folder and sub folder
        private void changeFolderRecursion(string folderDir, int length, bool hasChar)
        {
            changeNameInFolder(folderDir, length, hasChar);
            string[] subFolder = Directory.GetDirectories(folderDir);

            foreach (string item in subFolder)
            {
                changeFolderRecursion(item, length, hasChar);
            }
        }

        // validate textbox length
        private Boolean checkTextBoxLength(String tbLength)
        {
            if (string.IsNullOrEmpty(tbLength))
            {
                return false;
            }

            // isdigit
            // 48:0            57:9
            foreach (char item in tbLength)
            {
                if (item < 48 || item > 57)
                {
                    return false;
                }
            }

            return true;
        }

        // handle button change
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxLength(cb_nameLength.Text))
            {
                MessageBox.Show("length are wrong");
                return;
            }

            if (!string.IsNullOrEmpty(tb_dir.Text))
            {

                string[] files = Directory.GetFiles(tb_dir.Text);

                string[] subFolder = Directory.GetDirectories(tb_dir.Text);


                int length = Int32.Parse(cb_nameLength.Text);

                if (cb_recursion.Checked)
                {
                    changeFolderRecursion(tb_dir.Text, length, cb_hasChar.Checked);
                }
                else
                {
                    changeNameInFolder(tb_dir.Text, length, cb_hasChar.Checked); 
                }

            }
            else
            {
                MessageBox.Show("Directory folder is empty");
            }
        }

        // handle button exit
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
