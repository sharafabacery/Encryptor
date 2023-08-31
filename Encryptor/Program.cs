using System;
namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptorController encryptorController = new EncryptorController();
            int operation;
            ConsoleDispaly.WelcomeDispaly();
            while (true)
            {
                ConsoleDispaly.EnterYourOpertion();
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 0) break;
                ConsoleDispaly.InsertKey();
                encryptorController.SetKeys(Convert.ToString(Console.ReadLine()));
                try
                {
                    if (operation == 1)
                    {
                        ConsoleDispaly.InsertFilePath();
                        if (encryptorController.ApplyEncryption(Console.ReadLine()))
                        {
                            ConsoleDispaly.SuccessMessage();
                        }
                        else
                        {
                            ConsoleDispaly.FailedMessage();
                        }
                    }
                    else if (operation == 2)
                    {
                        ConsoleDispaly.InsertFilePath();
                        if (encryptorController.ApplyDecryption(Console.ReadLine()))
                        {
                            ConsoleDispaly.SuccessMessage();
                        }
                        else
                        {
                            ConsoleDispaly.FailedMessage();
                        }
                    }
                    else if(operation==3){
                        ConsoleDispaly.InsertDirectoryPath();
                        encryptorController.ApplyEncryptionDirectory(Console.ReadLine(),0);
                        ConsoleDispaly.NumberOfFilesProceed(encryptorController.NumberOfFilesAffected());
                    }
                    else if(operation==4){
                        ConsoleDispaly.InsertDirectoryPath();
                        encryptorController.ApplyDecryptionDirectory(Console.ReadLine(),0);
                        ConsoleDispaly.NumberOfFilesProceed(encryptorController.NumberOfFilesAffected());
                    }
                    else if(operation==5){
                        ConsoleDispaly.InsertDirectoryPath();
                        encryptorController.ApplyEncryptionDirectory(Console.ReadLine(),null);
                        ConsoleDispaly.NumberOfFilesProceed(encryptorController.NumberOfFilesAffected());
                    }
                    else if(operation==6){
                        ConsoleDispaly.InsertDirectoryPath();
                        encryptorController.ApplyDecryptionDirectory(Console.ReadLine(),null);
                        ConsoleDispaly.NumberOfFilesProceed(encryptorController.NumberOfFilesAffected());
                    }
                }
                catch (System.Exception E)
                {
                    System.Console.WriteLine(E.Message);

                }

            }


            //EncryptorController encryptorController =new EncryptorController("a7a7a7a7a7a7a7a7a7");
            // encryptorController.ApplyEncryptionDirectories("C:\\Users\\Sharaf Elden\\Desktop\\New folder (2)");
            //encryptorController.ApplyDecryptionDirectories("C:\\Users\\Sharaf Elden\\Desktop\\New folder (2)");

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
           
            DirectoryNavigator directoryNavigator=new DirectoryNavigator();
            directoryNavigator.GetSubDirectoriesofDirectory("F:\\sql server");
            foreach (var item in directoryNavigator.Directories)
            {
                System.Console.WriteLine("Directory name: "+item.DirectoryPath);
                foreach(var item2 in item.files){
                    System.Console.WriteLine("File name: "+item2);
                }
            } */
            //File.Delete("F:\\New folder (3)\\New Bitmap Image.bmp");

        }
    }
}