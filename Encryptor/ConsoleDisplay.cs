using System;
namespace Encryptor
{
    public static class ConsoleDispaly{
        public static void WelcomeDispaly(){
            System.Console.WriteLine("Hey My name is Encryptor,I can make serval Features:\n 1)Encrypt File \n 2)Decrypt File \n 3)Encrypt Directory\n 4)Decrypt Directory \n 5)Encrypt Directory wth sub-Directories \n 6)Decrypt Directory wth sub-Directories \n 0)exit \n");
        }
        public static void InsertKey(){
            System.Console.WriteLine("please insert key to begin the process: \n");
        }
        public static void EnterYourOpertion(){
            System.Console.WriteLine(" you can choose one of them press 1,2,3,4,5,6 and 0 for exit \n");
        }
        public static void InsertFilePath(){
            System.Console.WriteLine("please insert file path to finish the process: \n");
        }
        public static void InsertDirectoryPath(){
            System.Console.WriteLine("please insert Directory path to finish the process: \n");
        } 
        public static void NumberOfFilesProceed(Tuple<int,int>x){
            System.Console.WriteLine($"Number of proceed files ${x.Item1} and Numer oF Total Files {x.Item2}");
        }
        public static void SuccessMessage(){
            System.Console.WriteLine("opeation complete and Successed");
        }
        public static void FailedMessage(){
            System.Console.WriteLine("opeation failed");
        }

    }
}