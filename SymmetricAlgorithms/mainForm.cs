using SymmetricAlgorithms.CipherMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetricAlgorithms
{
    public partial class mainForm : Form
    {
        private iCipherMethod chosenFileAlgorithm;
        private iCipherMethod chosenTextAlgorithm;
        private List<iCipherMethod> availableAlgorithms = new List<iCipherMethod>();
        private FileInfo chosenFileInfo;
        public mainForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(mainForm_DragEnter);
            this.DragDrop += new DragEventHandler(mainForm_DragDrop);
        }
        //EVENTS
        //DRAG n DROP EVENTS
        void mainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!isValidFile(files[0])) {
                MessageBox.Show("Invalid file.", "ERROR");
                return;
            }
            textbox_fileDir.Text = files[0];
            loadFileInfo(files[0]);
        }
        void mainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
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
            this.chosenFileInfo = loadedFileInfo;
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
        private void button_textEncrypt_Click(object sender, EventArgs e)
        {
            this.textbox_textResult.Text = this.chosenTextAlgorithm.encryptString(textBox_textInput.Text, textbox_textPassword.Text);
        }

        private void button_textDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedMessage = this.chosenTextAlgorithm.decryptString(textBox_textInput.Text, textbox_textPassword.Text);
            if(decryptedMessage.Length == 0)
            {
                MessageBox.Show("Error decrypting.", "ERROR");
            }
            this.textbox_textResult.Text = decryptedMessage;
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
            if (textbox_fileDir.Text == "") { return; }
            //Files bigger than 500MB are forbidden (RAM ISSUES)
            if (this.chosenFileInfo != null && this.chosenFileInfo.Length > 1000 * 1000 * 500) {
                MessageBox.Show($"The file is too heavy. ({this.getFormattedFileSize(this.chosenFileInfo.Length)} / 500MB)", "ERROR");
                return;
            }
            String filePath = chooseSaveFileFolder();
            if (filePath == String.Empty) { return; }
            if (!File.Exists(filePath) && File.Exists(textbox_fileDir.Text))
            {
                //Get bytes of decrypted file
                byte[] encryptedFile = this.chosenFileAlgorithm.encryptFile(System.IO.File.ReadAllBytes(textbox_fileDir.Text), textbox_filePassword.Text);
                if (encryptedFile.Length == 0)
                {
                    //If array length is 0
                    MessageBox.Show("Error encrypting.", "ERROR");
                    return;
                }

                //Write the file
                File.WriteAllBytes(filePath + this.chosenFileAlgorithm.getExtensionEncrypt(), encryptedFile);
            }
        }

        private void button_fileDecrypt_Click(object sender, EventArgs e)
        {
            if (textbox_fileDir.Text == "") { return; }
            //Files bigger than 500MB are forbidden (RAM ISSUES)
            if (this.chosenFileInfo != null && this.chosenFileInfo.Length > 1000 * 1000 * 500)
            {
                MessageBox.Show($"The file is too heavy. ({this.getFormattedFileSize(this.chosenFileInfo.Length)} / 500MB)", "ERROR");
                return;
            }
            String filePath = chooseSaveFileFolder();
            if (filePath == String.Empty) { return; }
            if (!File.Exists(filePath) && File.Exists(textbox_fileDir.Text))
            {
                //Get bytes of decrypted file
                byte[] decryptedFile = this.chosenFileAlgorithm.decryptFile(System.IO.File.ReadAllBytes(textbox_fileDir.Text), textbox_filePassword.Text);
                if(decryptedFile.Length == 0)
                {
                    //If array length is 0
                    MessageBox.Show("Error decrypting.", "ERROR");
                    return;
                }

                //Write the file
                File.WriteAllBytes(filePath, decryptedFile);
            }
        }

        private void combobox_fileAlgorithm_SelectedValueChanged(object sender, EventArgs e)
        {
            //Change chosenFileAlgorithm value when choosing another type
            DataRowView selectedValueRow = (DataRowView)combobox_fileAlgorithm.SelectedItem;
            if (selectedValueRow != null)
            {
                chosenFileAlgorithm = (iCipherMethod)selectedValueRow[1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SymmetricAlgorithms available
            //https://msdn.microsoft.com/en-us/library/system.security.cryptography.symmetricalgorithm(v=vs.110).aspx
            availableAlgorithms.Add(new AES());
            availableAlgorithms.Add(new DES());
            availableAlgorithms.Add(new RC2());
            availableAlgorithms.Add(new Rijndael());
            availableAlgorithms.Add(new TripleDES());
            loadAvailableAlgorithms();
        }

        private void loadAvailableAlgorithms()
        {
            DataTable tmp_dt = new DataTable();
            tmp_dt.Clear();
            tmp_dt.Columns.Add("name", typeof(String));
            tmp_dt.Columns.Add("iCipherMethod", typeof(iCipherMethod));

            foreach (iCipherMethod algorithm in availableAlgorithms)
            {
                DataRow algorithmRow = tmp_dt.NewRow();
                algorithmRow["name"] = algorithm.getName();
                algorithmRow["iCipherMethod"] = algorithm;
                tmp_dt.Rows.Add(algorithmRow);
            }


            //Reset items from combobox FILE
            combobox_fileAlgorithm.Items.Clear();

            combobox_fileAlgorithm.ValueMember = "iCipherMethod";
            combobox_fileAlgorithm.DisplayMember = "name";
            combobox_fileAlgorithm.DataSource = tmp_dt;

            //Reset items from combobox TEXT
            combobox_textAlgorithm.Items.Clear();

            combobox_textAlgorithm.ValueMember = "iCipherMethod";
            combobox_textAlgorithm.DisplayMember = "name";
            combobox_textAlgorithm.DataSource = tmp_dt;
        }

        private void combobox_textAlgorithm_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView selectedValueRow = (DataRowView)combobox_textAlgorithm.SelectedItem;
            if (selectedValueRow != null)
            {
                chosenTextAlgorithm = (iCipherMethod)selectedValueRow[1];
            }
        }

        private void textBox_textInput_TextChanged(object sender, EventArgs e)
        {
            //Reset result when input changes
            textbox_textResult.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start("https://alexparedes.ovh/");
        }
    }
}
