
namespace GYMproj
{
    partial class GYM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GYM));
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(8, 238);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(203, 60);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(455, 238);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(203, 60);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextbox.Location = new System.Drawing.Point(140, 62);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(450, 34);
            this.fileNameTextbox.TabIndex = 2;
            this.fileNameTextbox.TextChanged += new System.EventHandler(this.pathTextbox_TextChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(3, 177);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(66, 29);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "label";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(217, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "Change Path";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.chngPath_Click);
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextbox.Location = new System.Drawing.Point(140, 102);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.Size = new System.Drawing.Size(450, 34);
            this.filePathTextbox.TabIndex = 6;
            this.filePathTextbox.Visible = false;
            this.filePathTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "FIle Name:";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.Location = new System.Drawing.Point(3, 107);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(114, 29);
            this.filePathLabel.TabIndex = 8;
            this.filePathLabel.Text = "FIle Path:";
            this.filePathLabel.Visible = false;
            this.filePathLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // GYM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 313);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GYM";
            this.Text = "GYM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filePathLabel;
    }
}

