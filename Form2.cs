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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open(MainClass.fileName, FileMode.Open, FileAccess.Write));
                nameOfFIle.Text = MainClass.fileName;
                sizeOfFile.Text = ((int)bw.BaseStream.Length).ToString();
                numOfRec.Text = ((int)bw.BaseStream.Length / MainClass.fileSize).ToString();
                bw.Close();
                label2.BackColor = Color.Transparent;
                groupBox2.BackColor = Color.Transparent;
                Details.BackColor = Color.Transparent;
                maleRadioButton.BackColor = Color.Transparent;
                FemaleRadioButton2.BackColor = Color.Transparent;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(MainClass.fileName, FileMode.Open, FileAccess.Write));
            try
            {
                int len = (int)bw.BaseStream.Length;

                if (len > 0)
                    bw.BaseStream.Seek(len, SeekOrigin.Begin);

                bw.Write(int.Parse(IDtextBox.Text));                       // write ID
                NametextBox.Text = NametextBox.Text.PadRight(9);
                bw.Write(NametextBox.Text.Substring(0, 9));                // Write Name
                if (FemaleRadioButton2.Checked)                                  // Write Gender
                    bw.Write(2);
                else
                    bw.Write(1);
                bw.Write(int.Parse(datetextBox.Text));                     // Write Date
                bw.Write(int.Parse(expireDateTextbox.Text));               // Write Expire Date

                int lenght = (int)bw.BaseStream.Length;
                sizeOfFile.Text = lenght.ToString();                      // Size of File Label
                numOfRec.Text = (lenght / MainClass.fileSize).ToString(); // Number Of Record

                IDtextBox.Text = NametextBox.Text = datetextBox.Text = expireDateTextbox.Text = "";
                maleRadioButton.Checked = false;
                FemaleRadioButton2.Checked = false;

                MessageBox.Show("Data is saved successfully");
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            bw.Close();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(MainClass.fileName, FileMode.Open, FileAccess.Read));
            try
            {
                int numberOfRecord = (int)br.BaseStream.Length / MainClass.fileSize;
                int lengthOfFile = (int)br.BaseStream.Length;

                if (numberOfRecord > 0) // If The file Not Empty
                {
                    MainClass.modifyLength = MainClass.count;
                    displayBtn.Text = "Next";                                           // Change the Button Text
                    numOfRec.Text = numberOfRecord.ToString();                          // Number of Records Label
                    sizeOfFile.Text = lengthOfFile.ToString();                          // File Size Lable
                    br.BaseStream.Seek(MainClass.count, SeekOrigin.Begin);              // Move to Specific Position in a File

                    IDtextBox.Text = br.ReadInt32().ToString();                         // Set ID
                    NametextBox.Text = br.ReadString();                                 // Set Name
                    int gender = br.ReadInt32();                                        // Set Gender
                    if (gender == 2)
                        FemaleRadioButton2.Checked = true;
                    else
                        maleRadioButton.Checked = true;
                    datetextBox.Text = br.ReadInt32().ToString();                       // Set Date
                    expireDateTextbox.Text = br.ReadInt32().ToString();                 // Set Expire Date

                    if ((MainClass.count / MainClass.fileSize) >= (numberOfRecord - 1))  // If I reach the End of file , Go to the Beginning of file
                        MainClass.count = 0;
                    else
                        MainClass.count += MainClass.fileSize;
                }
                else MessageBox.Show("Empty File");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            br.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            IDtextBox.Text = NametextBox.Text = datetextBox.Text = expireDateTextbox.Text = "";
            maleRadioButton.Checked = false;
            FemaleRadioButton2.Checked = false;
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(MainClass.fileName, FileMode.Open, FileAccess.Write));
            try
            {
                bw.BaseStream.Seek(MainClass.modifyLength, SeekOrigin.Current);

                bw.Write(int.Parse(IDtextBox.Text));                       // write ID
                NametextBox.Text = NametextBox.Text.PadRight(9);
                bw.Write(NametextBox.Text.Substring(0, 9));                // Write Name
                if (FemaleRadioButton2.Checked)                                  // Write Gender
                    bw.Write(2);
                else
                    bw.Write(1);
                bw.Write(int.Parse(datetextBox.Text));                     // Write Date
                bw.Write(int.Parse(expireDateTextbox.Text));               // Write Expire Date

                IDtextBox.Text = NametextBox.Text = datetextBox.Text = expireDateTextbox.Text = "";
                maleRadioButton.Checked = false;
                FemaleRadioButton2.Checked = false;

                int lenght = (int)bw.BaseStream.Length;
                numOfRec.Text = (lenght / MainClass.fileSize).ToString();
                sizeOfFile.Text = lenght.ToString();
                MessageBox.Show("Data is saved successfully");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            bw.Close();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GYM().Show();
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayBtn.Visible = false;
            modifyBtn.Visible = false;
            saveBtn.Visible = true;
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveBtn.Visible = false;
            modifyBtn.Visible = false;
            displayBtn.Visible = true;
        }

        private void mODIFYDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveBtn.Visible = false;
            displayBtn.Visible = false;
            modifyBtn.Visible = true;
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            serchtextBox.Visible = true;
            SearchBtn.Visible = true;
            saveBtn.Visible = false;
            modifyBtn.Visible = false;
            displayBtn.Visible = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(MainClass.fileName, FileMode.Open, FileAccess.Read));
            try
            {

                bool found = false;
                long num_of_records = br.BaseStream.Length / MainClass.fileSize;
                numOfRec.Text = num_of_records.ToString();

                int VarSearchID = int.Parse(serchtextBox.Text);
                while (num_of_records > 0)
                {
                    br.BaseStream.Seek(MainClass.searchCount, SeekOrigin.Begin);

                    if (VarSearchID == br.ReadInt32())
                    {
                        IDtextBox.Text = VarSearchID.ToString();                            // Set ID
                        NametextBox.Text = br.ReadString();                                 // Set Name
                        int gender = br.ReadInt32();                                        // Set Gender
                        if (gender == 2)
                            FemaleRadioButton2.Checked = true;
                        else
                            maleRadioButton.Checked = true;
                        datetextBox.Text = br.ReadInt32().ToString();                       // Set Date
                        expireDateTextbox.Text = br.ReadInt32().ToString();                 // Set Expire Date

                        found = true;
                        break;
                    }
                    else
                        MainClass.searchCount += MainClass.fileSize;

                    br.ReadInt32();
                    br.ReadInt32().ToString();
                    br.ReadInt32();
                    br.ReadInt32();
                    br.ReadInt32();
                    --num_of_records;
                }
                if (!found) // If The file Not Empty OR Not Found
                {
                    MessageBox.Show("ID not found", "Not Found", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ID Not Found", "Not Found");
            }
            br.Close();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveBtn.Visible = true;
            displayBtn.Visible = true;
            modifyBtn.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
