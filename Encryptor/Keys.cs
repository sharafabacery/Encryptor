using System;
using System.Security.Cryptography;
using System.Text;
namespace Encryptor
{
    class Keys
    {
        private string key ;
         
         public Keys(string Key){
            this.key=Key;
         }
        public byte[] KeyByte()
        {
            HashAlgorithm hash = MD5.Create();
            return hash.ComputeHash(Encoding.Unicode.GetBytes(this.key));
        }




    }
}