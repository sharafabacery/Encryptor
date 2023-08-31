using System;
namespace Encryptor
{
    class EncryptorController
    {
        private DirectoryNavigator directoryNavigator;
        private Encryption encryption;
        private Decryption decryption;
        private Keys keys;
        private int numberOfAffectedFiles;
        private int totalFiles;
        private Byte[] ByteKey;

        public EncryptorController(string key)
        {
            keys = new Keys(key);
            ByteKey = keys.KeyByte();
            encryption = new Encryption(ByteKey);
            decryption = new Decryption(ByteKey);
            numberOfAffectedFiles = 0;
            totalFiles = 0;
        }
        public void SetKeys(string key)
        {
            keys.Key = key;
            ByteKey = keys.KeyByte();
            encryption = new Encryption(ByteKey);
            decryption = new Decryption(ByteKey);
        }
        public Tuple<int,int> NumberOfFilesAffected()
        {
            int returned1=this.numberOfAffectedFiles;
            int returned2=this.totalFiles;
            this.numberOfAffectedFiles=0;
            this.totalFiles=0;
            return Tuple.Create(returned1,returned2);
        }

        public bool ApplyEncryption(string filePath)
        {
            bool complete = true;
            try
            {
                encryption.FilePath = filePath;
                encryption.EncryptFile();

            }
            catch (System.Exception)
            {

                complete = false;
            }
            return complete;
        }

        public bool ApplyDecryption(string filePath)
        {
            bool complete = true;
            try
            {
                decryption.FilePath = filePath;
                decryption.DecryptFile();
            }
            catch (System.Exception)
            {

                complete = false;
            }
            return complete;

        }
        
        
        public void ApplyEncryptionDirectory(string directoryPath,Nullable<int> depth)
        {
            directoryNavigator = new DirectoryNavigator();
            directoryNavigator.GetDirectory(directoryPath,depth);
            foreach (var item in directoryNavigator.Directories)
            {
                totalFiles += item.files.Count;
                foreach (var item2 in item.files)
                {
                    if (!this.ApplyEncryption(item2))
                    {
                        break;
                    }
                    else
                    {
                        numberOfAffectedFiles++;
                    }
                }

            }
        }
        public void ApplyDecryptionDirectory(string directoryPath,Nullable<int>depth)
        {
            directoryNavigator = new DirectoryNavigator();
            directoryNavigator.GetDirectory(directoryPath,depth);
            foreach (var item in directoryNavigator.Directories)
            {
                totalFiles += item.files.Count;
                foreach (var item2 in item.files)
                {
                    if (!this.ApplyDecryption(item2))
                    {
                        break;
                    }
                    else
                    {
                        numberOfAffectedFiles++;
                    }
                }

            }
        }


    }
}