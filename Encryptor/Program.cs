using System;
namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Keys keys =new Keys();
            keys.Key="SGVsbG8gdGhlcmUh";
            DirectoryBuilder directoryBuilder =new DirectoryBuilder();
            directoryBuilder
            .DirectoryPath="C:\\Users\\Sharaf Elden\\Downloads\\New folder";
            directoryBuilder.DirectoryFiles(directoryBuilder.DirectoryPath);

            Encryption encryption =new Encryption();
            foreach (var item in directoryBuilder.files)
            {
            encryption.EncryptFile(item,keys.KeyByte());
                
            }
            ///encryption.EncryptFile("F:\\.Net Stack ITI\\projects\\Encryptor\\Encryptor\\38.mp4",keys.KeyByte());
            //Decryption decryption=new Decryption();
            //decryption.DecryptFile("F:\\.Net Stack ITI\\projects\\Encryptor\\Encryptor\\38.mp4",keys.KeyByte());
            */
            DirectoryNavigator directoryNavigator=new DirectoryNavigator();
            directoryNavigator.GetSubDirectoriesofDirectory("F:\\sql server");
            foreach (var item in directoryNavigator.Directories)
            {
                System.Console.WriteLine("Directory name: "+item.DirectoryPath);
                foreach(var item2 in item.files){
                    System.Console.WriteLine("File name: "+item2);
                }
            }

        }
    }
}