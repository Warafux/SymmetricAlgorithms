namespace SymmetricAlgorithms
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_fileAlgorithm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_fileDecrypt = new System.Windows.Forms.Button();
            this.textbox_filePassword = new System.Windows.Forms.TextBox();
            this.button_fileEncrypt = new System.Windows.Forms.Button();
            this.textbox_loadedFileSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_loadedFileExtension = new System.Windows.Forms.TextBox();
            this.picturebox_loadedFileIcon = new System.Windows.Forms.PictureBox();
            this.textbox_loadedFileName = new System.Windows.Forms.TextBox();
            this.button_loadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_fileDir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_textResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combobox_textAlgorithm = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_textDecrypt = new System.Windows.Forms.Button();
            this.textbox_textPassword = new System.Windows.Forms.TextBox();
            this.button_textEncrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_textInput = new System.Windows.Forms.TextBox();
            this.openFileDialog_loadFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loadedFileIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.combobox_fileAlgorithm);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_fileDecrypt);
            this.tabPage1.Controls.Add(this.textbox_filePassword);
            this.tabPage1.Controls.Add(this.button_fileEncrypt);
            this.tabPage1.Controls.Add(this.textbox_loadedFileSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textbox_loadedFileExtension);
            this.tabPage1.Controls.Add(this.picturebox_loadedFileIcon);
            this.tabPage1.Controls.Add(this.textbox_loadedFileName);
            this.tabPage1.Controls.Add(this.button_loadFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textbox_fileDir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Algorithm";
            // 
            // combobox_fileAlgorithm
            // 
            this.combobox_fileAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_fileAlgorithm.FormattingEnabled = true;
            this.combobox_fileAlgorithm.Location = new System.Drawing.Point(77, 117);
            this.combobox_fileAlgorithm.Name = "combobox_fileAlgorithm";
            this.combobox_fileAlgorithm.Size = new System.Drawing.Size(165, 21);
            this.combobox_fileAlgorithm.TabIndex = 17;
            this.combobox_fileAlgorithm.SelectedValueChanged += new System.EventHandler(this.combobox_fileAlgorithm_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passphrase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "File size";
            // 
            // button_fileDecrypt
            // 
            this.button_fileDecrypt.Location = new System.Drawing.Point(7, 194);
            this.button_fileDecrypt.Name = "button_fileDecrypt";
            this.button_fileDecrypt.Size = new System.Drawing.Size(481, 28);
            this.button_fileDecrypt.TabIndex = 14;
            this.button_fileDecrypt.Text = "Decrypt and save to file...";
            this.button_fileDecrypt.UseVisualStyleBackColor = true;
            this.button_fileDecrypt.Click += new System.EventHandler(this.button_fileDecrypt_Click);
            // 
            // textbox_filePassword
            // 
            this.textbox_filePassword.Location = new System.Drawing.Point(316, 118);
            this.textbox_filePassword.Name = "textbox_filePassword";
            this.textbox_filePassword.Size = new System.Drawing.Size(172, 20);
            this.textbox_filePassword.TabIndex = 13;
            // 
            // button_fileEncrypt
            // 
            this.button_fileEncrypt.Location = new System.Drawing.Point(7, 159);
            this.button_fileEncrypt.Name = "button_fileEncrypt";
            this.button_fileEncrypt.Size = new System.Drawing.Size(481, 29);
            this.button_fileEncrypt.TabIndex = 12;
            this.button_fileEncrypt.Text = "Encrypt and save to file...";
            this.button_fileEncrypt.UseVisualStyleBackColor = true;
            this.button_fileEncrypt.Click += new System.EventHandler(this.button_fileEncrypt_Click);
            // 
            // textbox_loadedFileSize
            // 
            this.textbox_loadedFileSize.Location = new System.Drawing.Point(77, 89);
            this.textbox_loadedFileSize.Name = "textbox_loadedFileSize";
            this.textbox_loadedFileSize.ReadOnly = true;
            this.textbox_loadedFileSize.Size = new System.Drawing.Size(172, 20);
            this.textbox_loadedFileSize.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File extension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Icon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File name";
            // 
            // textbox_loadedFileExtension
            // 
            this.textbox_loadedFileExtension.Location = new System.Drawing.Point(269, 46);
            this.textbox_loadedFileExtension.Name = "textbox_loadedFileExtension";
            this.textbox_loadedFileExtension.ReadOnly = true;
            this.textbox_loadedFileExtension.Size = new System.Drawing.Size(100, 20);
            this.textbox_loadedFileExtension.TabIndex = 7;
            // 
            // picturebox_loadedFileIcon
            // 
            this.picturebox_loadedFileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_loadedFileIcon.Location = new System.Drawing.Point(7, 45);
            this.picturebox_loadedFileIcon.Name = "picturebox_loadedFileIcon";
            this.picturebox_loadedFileIcon.Size = new System.Drawing.Size(64, 64);
            this.picturebox_loadedFileIcon.TabIndex = 1;
            this.picturebox_loadedFileIcon.TabStop = false;
            // 
            // textbox_loadedFileName
            // 
            this.textbox_loadedFileName.Location = new System.Drawing.Point(77, 46);
            this.textbox_loadedFileName.Name = "textbox_loadedFileName";
            this.textbox_loadedFileName.ReadOnly = true;
            this.textbox_loadedFileName.Size = new System.Drawing.Size(172, 20);
            this.textbox_loadedFileName.TabIndex = 6;
            // 
            // button_loadFile
            // 
            this.button_loadFile.Location = new System.Drawing.Point(397, 5);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.Size = new System.Drawing.Size(85, 23);
            this.button_loadFile.TabIndex = 5;
            this.button_loadFile.Text = "Load file";
            this.button_loadFile.UseVisualStyleBackColor = true;
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Dir";
            // 
            // textbox_fileDir
            // 
            this.textbox_fileDir.Location = new System.Drawing.Point(45, 6);
            this.textbox_fileDir.Name = "textbox_fileDir";
            this.textbox_fileDir.Size = new System.Drawing.Size(346, 20);
            this.textbox_fileDir.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textbox_textResult);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.combobox_textAlgorithm);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button_textDecrypt);
            this.tabPage2.Controls.Add(this.textbox_textPassword);
            this.tabPage2.Controls.Add(this.button_textEncrypt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_textInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Result:";
            // 
            // textbox_textResult
            // 
            this.textbox_textResult.Location = new System.Drawing.Point(10, 177);
            this.textbox_textResult.Multiline = true;
            this.textbox_textResult.Name = "textbox_textResult";
            this.textbox_textResult.ReadOnly = true;
            this.textbox_textResult.Size = new System.Drawing.Size(475, 50);
            this.textbox_textResult.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Algorithm";
            // 
            // combobox_textAlgorithm
            // 
            this.combobox_textAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_textAlgorithm.FormattingEnabled = true;
            this.combobox_textAlgorithm.Location = new System.Drawing.Point(66, 82);
            this.combobox_textAlgorithm.Name = "combobox_textAlgorithm";
            this.combobox_textAlgorithm.Size = new System.Drawing.Size(160, 21);
            this.combobox_textAlgorithm.TabIndex = 18;
            this.combobox_textAlgorithm.SelectedValueChanged += new System.EventHandler(this.combobox_textAlgorithm_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Passphrase";
            // 
            // button_textDecrypt
            // 
            this.button_textDecrypt.Location = new System.Drawing.Point(10, 135);
            this.button_textDecrypt.Name = "button_textDecrypt";
            this.button_textDecrypt.Size = new System.Drawing.Size(475, 23);
            this.button_textDecrypt.TabIndex = 4;
            this.button_textDecrypt.Text = "Decrypt";
            this.button_textDecrypt.UseVisualStyleBackColor = true;
            this.button_textDecrypt.Click += new System.EventHandler(this.button_textDecrypt_Click);
            // 
            // textbox_textPassword
            // 
            this.textbox_textPassword.Location = new System.Drawing.Point(297, 83);
            this.textbox_textPassword.Name = "textbox_textPassword";
            this.textbox_textPassword.Size = new System.Drawing.Size(188, 20);
            this.textbox_textPassword.TabIndex = 3;
            // 
            // button_textEncrypt
            // 
            this.button_textEncrypt.Location = new System.Drawing.Point(10, 106);
            this.button_textEncrypt.Name = "button_textEncrypt";
            this.button_textEncrypt.Size = new System.Drawing.Size(475, 23);
            this.button_textEncrypt.TabIndex = 2;
            this.button_textEncrypt.Text = "Encrypt";
            this.button_textEncrypt.UseVisualStyleBackColor = true;
            this.button_textEncrypt.Click += new System.EventHandler(this.button_textEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Text area:";
            // 
            // textBox_textInput
            // 
            this.textBox_textInput.Location = new System.Drawing.Point(10, 23);
            this.textBox_textInput.Multiline = true;
            this.textBox_textInput.Name = "textBox_textInput";
            this.textBox_textInput.Size = new System.Drawing.Size(475, 50);
            this.textBox_textInput.TabIndex = 0;
            this.textBox_textInput.TextChanged += new System.EventHandler(this.textBox_textInput_TextChanged);
            // 
            // openFileDialog_loadFile
            // 
            this.openFileDialog_loadFile.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Made by Warafu";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 292);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Symmetric Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loadedFileIcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_loadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_fileDir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadFile;
        private System.Windows.Forms.TextBox textbox_loadedFileName;
        private System.Windows.Forms.PictureBox picturebox_loadedFileIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_loadedFileExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_loadedFileSize;
        private System.Windows.Forms.Button button_textEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_textInput;
        private System.Windows.Forms.TextBox textbox_textPassword;
        private System.Windows.Forms.Button button_textDecrypt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_saveFile;
        private System.Windows.Forms.Button button_fileEncrypt;
        private System.Windows.Forms.TextBox textbox_filePassword;
        private System.Windows.Forms.Button button_fileDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combobox_fileAlgorithm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combobox_textAlgorithm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_textResult;
        private System.Windows.Forms.Label label12;
    }
}

