namespace AESCipher
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_loadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_fileDir = new System.Windows.Forms.TextBox();
            this.openFileDialog_loadFile = new System.Windows.Forms.OpenFileDialog();
            this.textbox_loadedFileName = new System.Windows.Forms.TextBox();
            this.picturebox_loadedFileIcon = new System.Windows.Forms.PictureBox();
            this.textbox_loadedFileExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_loadedFileSize = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loadedFileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 150);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(494, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // openFileDialog_loadFile
            // 
            this.openFileDialog_loadFile.FileName = "openFileDialog1";
            // 
            // textbox_loadedFileName
            // 
            this.textbox_loadedFileName.Location = new System.Drawing.Point(77, 46);
            this.textbox_loadedFileName.Name = "textbox_loadedFileName";
            this.textbox_loadedFileName.Size = new System.Drawing.Size(172, 20);
            this.textbox_loadedFileName.TabIndex = 6;
            // 
            // picturebox_loadedFileIcon
            // 
            this.picturebox_loadedFileIcon.Location = new System.Drawing.Point(7, 45);
            this.picturebox_loadedFileIcon.Name = "picturebox_loadedFileIcon";
            this.picturebox_loadedFileIcon.Size = new System.Drawing.Size(64, 64);
            this.picturebox_loadedFileIcon.TabIndex = 1;
            this.picturebox_loadedFileIcon.TabStop = false;
            // 
            // textbox_loadedFileExtension
            // 
            this.textbox_loadedFileExtension.Location = new System.Drawing.Point(269, 46);
            this.textbox_loadedFileExtension.Name = "textbox_loadedFileExtension";
            this.textbox_loadedFileExtension.Size = new System.Drawing.Size(100, 20);
            this.textbox_loadedFileExtension.TabIndex = 7;
            this.textbox_loadedFileExtension.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File extension";
            // 
            // textbox_loadedFileSize
            // 
            this.textbox_loadedFileSize.Location = new System.Drawing.Point(77, 89);
            this.textbox_loadedFileSize.Name = "textbox_loadedFileSize";
            this.textbox_loadedFileSize.Size = new System.Drawing.Size(172, 20);
            this.textbox_loadedFileSize.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 283);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loadedFileIcon)).EndInit();
            this.ResumeLayout(false);

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
    }
}

