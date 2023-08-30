using System;
using System.IO;
using System.Security.Cryptography;
namespace Encryptor
{
    class Encryption
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public string FilePath{set;get;}="";
        private byte[] key;
        public Encryption( byte[] key)
        { 
            this.key = key;
        }
        
        public void EncryptFile()
        {
            string tempFile = this.FilePath + ".temp";

            using (var aes = Aes.Create())
            {
                aes.Key = this.key;
                aes.IV = IV;

                using (var inputFileStream = new FileStream(this.FilePath, FileMode.Open))
                using (var outputFileStream = new FileStream(tempFile, FileMode.Create))
                using (var cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream);
                }
            }

            ClearFile.ClearFileFunction(this.FilePath);
            File.Delete(this.FilePath);
            File.Move(tempFile, this.FilePath);
            //ClearFile.ClearFileFunction(tempFile);

            //File.Delete(tempFile);
        }





    }
}