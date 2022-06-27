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

namespace GYMproj
{
    public partial class GYM : Form
    {
        public GYM()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameTextbox.Text != "") 
                {
                    MainClass.fileName = MainClass.filePath + fileNameTextbox.Text + ".txt";
                    if (!File.Exists(MainClass.fileName))
                    {
                        File.Create(MainClass.fileName).Close();
                        MessageBox.Show("Created Successfully !");
                    }
                }
                else
                    throw new Exception("Please Enter Name OF The File");

                this.Hide();
                new Form2().Show(); //Second Form
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PathLabel.Text = MainClass.filePath;
        }

        private void pathTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameTextbox.Text == "")
                {
                    throw new Exception("Please Enter Name OF The File");
                }
                else
                {
                    MainClass.fileName = MainClass.filePath + fileNameTextbox.Text + ".txt";
                    File.Delete(MainClass.fileName);
                    MessageBox.Show("Deleted Successfully");
                    fileNameTextbox.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chngPath_Click(object sender, EventArgs e)
        {
            filePathLabel.Visible = true;
            filePathTextbox.Visible = true;
            try
            {
                if (filePathTextbox.Text == "")
                {
                    throw new Exception("Please Enter The Path");
                }
                else
                {
                    MainClass.filePath = filePathTextbox.Text + "\\";
                    MessageBox.Show("Path Changed Successfully");
                    filePathTextbox.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
