using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESCipher
{
    interface iCipherMethod
    {
        string getName();
        byte[] encryptFile(byte[] file, string pass);
        byte[] decryptFile(byte[] file, string pass);

        string encryptString(string message, string pass);
        string decryptString(string message, string pass);
    }
}
