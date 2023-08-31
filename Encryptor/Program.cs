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

        }
    }
}