using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricAlgorithms.CipherMethods
{
    class DES : iCipherMethod
    {
        private DESCryptoServiceProvider des;
        private Encoding encoding;
        private string cipherName = "DES";
        private string extensionEncrypt = ".DES";
        public DES()
        {
            this.des = new DESCryptoServiceProvider();
            this.des.Mode = CipherMode.CBC;
            this.encoding = Encoding.Unicode;
        }
        public byte[] decryptFile(byte[] file, string pass)
        {
            string salt = getDerivedSalt(pass);

            DeriveBytes rgb = new Rfc2898DeriveBytes(pass, this.encoding.GetBytes(salt), 9);
            byte[] key = rgb.GetBytes(this.des.KeySize >> 3);
            byte[] iv = rgb.GetBytes(this.des.BlockSize >> 3);

            this.des.Key = key;
            this.des.IV = iv;
            ICryptoTransform decryptor = this.des.CreateDecryptor();
            byte[] datadecrypt;
            try
            {
                datadecrypt = decryptor.TransformFinalBlock(file, 0, file.Length);
            }
            catch (Exception e)
            {
                datadecrypt = new byte[0];
            }
            return datadecrypt;
        }
        public byte[] encryptFile(byte[] file, string pass)
        {
            string salt = getDerivedSalt(pass);
            DeriveBytes rgb = new Rfc2898DeriveBytes(pass, this.encoding.GetBytes(salt), 9);
            byte[] key = rgb.GetBytes(this.des.KeySize >> 3);
            byte[] iv = rgb.GetBytes(this.des.BlockSize >> 3);

            this.des.Key = key;
            this.des.IV = iv;
            ICryptoTransform encryptor = this.des.CreateEncryptor();
            byte[] dataencrypt;
            try
            {
                dataencrypt = encryptor.TransformFinalBlock(file, 0, file.Length);
            }
            catch (Exception e)
            {
                dataencrypt = new byte[0];
            }
            return dataencrypt;
        }
        public string getName() {
            return this.cipherName;
        }
        public string getExtensionEncrypt() {
            return this.extensionEncrypt;
        }
        public string encryptString(string message, string pass)
        {
            string salt = getDerivedSalt(pass);
            DeriveBytes rgb = new Rfc2898DeriveBytes(pass, this.encoding.GetBytes(salt), 9);
            byte[] key = rgb.GetBytes(this.des.KeySize >> 3);
            byte[] iv = rgb.GetBytes(this.des.BlockSize >> 3);

            this.des.Key = key;
            this.des.IV = iv;
            ICryptoTransform encryptor = this.des.CreateEncryptor();
            byte[] data = this.encoding.GetBytes(message);
            byte[] dataencrypt;
            try
            {
                dataencrypt = encryptor.TransformFinalBlock(data, 0, data.Length);
            }
            catch (Exception e)
            {
                dataencrypt = new byte[0];
            }
            return Convert.ToBase64String(dataencrypt);
        }
        public string decryptString(string message, string pass)
        {
            string salt = getDerivedSalt(pass);
            
            DeriveBytes rgb = new Rfc2898DeriveBytes(pass, this.encoding.GetBytes(salt), 9);
            byte[] key = rgb.GetBytes(this.des.KeySize >> 3);
            byte[] iv = rgb.GetBytes(this.des.BlockSize >> 3);

            this.des.Key = key;
            this.des.IV = iv;
            ICryptoTransform decryptor = this.des.CreateDecryptor();
            
            byte[] datadecrypt;
            try
            {
                byte[] data = Convert.FromBase64String(message);
                datadecrypt = decryptor.TransformFinalBlock(data, 0, data.Length);
            }
            catch (Exception e)
            {
                datadecrypt = new byte[0];
            }
            return this.encoding.GetString(datadecrypt);
        }
        private string getDerivedSalt(string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(this.encoding.GetBytes(password));
                
                return new string(this.encoding.GetChars(data));
            }
        }
    }
}
