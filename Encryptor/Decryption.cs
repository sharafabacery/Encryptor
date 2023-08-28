using System;
using System.IO;
using System.Security.Cryptography;
namespace Encryptor
{
    class Decryption
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
        private int BlockSize = 128;
        public  void DecryptFile(string filePath,byte[]key)
    {
        string tempFile = filePath + ".temp";

        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = IV;

            using (var inputFileStream = new FileStream(filePath, FileMode.Open))
            using (var outputFileStream = new FileStream(tempFile, FileMode.Create))
            using (var cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
            {
                //inputFileStream.SetLength(0);
                cryptoStream.CopyTo(outputFileStream);
            }
        }

        ClearFile.ClearFileFunction(filePath);
        File.Delete(filePath);
        File.Move(tempFile, filePath);
    }
    }
    }