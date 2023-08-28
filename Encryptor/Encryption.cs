using System;
using System.IO;
using System.Security.Cryptography;
namespace Encryptor
{
    class Encryption
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
        private string filePath;
        private byte[] key;
        public Encryption(string filePath,byte[]key){
            this.filePath=filePath;
            this.key=key;
        }
        public void EncryptFile()
    {
        string tempFile = this.filePath + ".temp";

        using (var aes = Aes.Create())
        {
            aes.Key = this.key; 
            aes.IV = IV;

           using (var inputFileStream = new FileStream(this.filePath, FileMode.Open))
            using (var outputFileStream = new FileStream(tempFile, FileMode.Create))
            using (var cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                inputFileStream.CopyTo(cryptoStream);
            }
        }

        ClearFile.ClearFileFunction(this.filePath);
        File.Delete(this.filePath);
        File.Move(tempFile, this.filePath);
        //ClearFile.ClearFileFunction(tempFile);
        
        //File.Delete(tempFile);
    }
        



        
    }
}