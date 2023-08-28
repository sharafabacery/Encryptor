using System;
using System.IO;
using System.Security.Cryptography;
namespace Encryptor
{
    class Encryption
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
        private int BlockSize = 128;
        public void EncryptFile(string filePath,byte[]key)
    {
        string tempFile = filePath + ".temp";

        using (var aes = Aes.Create())
        {
            aes.Key = key; 
            aes.IV = IV;

           using (var inputFileStream = new FileStream(filePath, FileMode.Open))
            using (var outputFileStream = new FileStream(tempFile, FileMode.Create))
            using (var cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                inputFileStream.CopyTo(cryptoStream);
            }
        }

        ClearFile.ClearFileFunction(filePath);
        File.Delete(filePath);
        File.Move(tempFile, filePath);
        //ClearFile.ClearFileFunction(tempFile);
        
        //File.Delete(tempFile);
    }
        



        
    }
}