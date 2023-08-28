using System;
using System.Security.Cryptography;
using System.Text;
namespace Encryptor
{
    class Keys
    {
        public string Key{get;set;}
        
        public byte[] KeyByte(){
            HashAlgorithm hash = MD5.Create();
            return  hash.ComputeHash(Encoding.Unicode.GetBytes(this.Key));
        }



        
    }
}