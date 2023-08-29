using System;
namespace Encryptor
{
    class DirectoryBuilder
    {
        public string DirectoryPath{private set;get;}

        public List<string> files{private set;get;}=new List<string>();
        public DirectoryBuilder(string directoryPath){
            this.DirectoryPath=directoryPath;
        }

        public void DirectoryFiles()
        {
            // Check if the directory exists
            if (!Directory.Exists(this.DirectoryPath))
            {
                throw new DirectoryNotFoundException($"Directory not found: {this.DirectoryPath}");
            }

            // Get the files in the directory
            files = Directory.GetFiles(this.DirectoryPath).ToList();

        }


    }
}