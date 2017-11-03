using AESCipher.CipherMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            String chosenFileDir = chooseFile();
            if (chosenFileDir == String.Empty) { return; }

            //clearFields();
            textbox_fileDir.Text = chosenFileDir;
            loadFileInfo(chosenFileDir);
        }
        private string chooseFile()
        {
            openFileDialog_loadFile.FilterIndex = 1;
            openFileDialog_loadFile.Multiselect = false;
            if (openFileDialog_loadFile.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog_loadFile.FileName;
            }
            return String.Empty;
        }
        private void loadFileInfo(string fileDir)
        {
            
            //Invalid file
            if (!isValidFile(fileDir)){ return; }

            FileInfo loadedFileInfo = new FileInfo(fileDir);
            
            //FILE ICON
            Bitmap fileIcon_Original = Icon.ExtractAssociatedIcon(fileDir).ToBitmap();
            Bitmap fileIcon_Resized = new Bitmap(fileIcon_Original, new Size(64, 64));
            picturebox_loadedFileIcon.Image = fileIcon_Resized;

            //FILE NAME
            textbox_loadedFileName.Text = loadedFileInfo.Name;

            //FILE EXTENSION
            textbox_loadedFileExtension.Text = loadedFileInfo.Extension;

            //FILE SIZE
            textbox_loadedFileSize.Text = this.getFormattedFileSize(loadedFileInfo.Length);
        }

        private string getFormattedFileSize(long length)
        {
            if (length < 1000)
            {
                return (length).ToString("#.##") + " B";
            }
            else if (length > 1000 && length < 1000000)
            {
                return (length / 1000f).ToString("#.##") + " KB";
            }
            else if (length > 1000000 && length < 1000000000)
            {
                return (length / 1000000f).ToString("#.##") + " MB";
            }
            else
            {
                return (length / 1000000000f).ToString("#.##") + " GB";
            }
        }

        private bool isValidFile(String fileDir)
        {
            return File.Exists(fileDir);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_textEncrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            Console.WriteLine(aes.encryptString(textBox_textInput.Text, textbox_textPassword.Text));
        }

        private void button_textDecrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            Console.WriteLine(aes.decryptString(textBox_textInput.Text, textbox_textPassword.Text));
        }
        private string chooseSaveFileFolder()
        {
            saveFileDialog_saveFile.Reset();
            if (saveFileDialog_saveFile.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog_saveFile.FileName;
            }
            return String.Empty;
        }

        private void button_fileEncrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            if (textbox_fileDir.Text == "") { return; }
            String filePath = chooseSaveFileFolder();
            if (filePath == String.Empty) { return; }
            if (!File.Exists(filePath) && File.Exists(textbox_fileDir.Text))
            {
                //Get bytes of decrypted file
                byte[] encryptedFile = aes.encryptFile(System.IO.File.ReadAllBytes(textbox_fileDir.Text), textbox_filePassword.Text);
                if (encryptedFile.Length == 0)
                {
                    //If array length is 0
                    Console.WriteLine("ERROR ENCRYPTING");
                    return;
                }

                //Write the file
                File.WriteAllBytes(filePath + ".AES", encryptedFile);
            }
        }

        private void button_fileDecrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            if (textbox_fileDir.Text == "") { return; }
            String filePath = chooseSaveFileFolder();
            if (filePath == String.Empty) { return; }
            if (!File.Exists(filePath) && File.Exists(textbox_fileDir.Text))
            {
                //Get bytes of decrypted file
                byte[] decryptedFile = aes.decryptFile(System.IO.File.ReadAllBytes(textbox_fileDir.Text), textbox_filePassword.Text);
                if(decryptedFile.Length == 0)
                {
                    //If array length is 0
                    Console.WriteLine("ERROR DECRYPTING");
                    return;
                }

                //Write the file
                File.WriteAllBytes(filePath, decryptedFile);
            }
        }
    }
}
