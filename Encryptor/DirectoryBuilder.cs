using System;
namespace Encryptor
{
    class DirectoryBuilder
    {
        private string directoryPath;

        public List<string> files{private set;get;}=new List<string>();
        public DirectoryBuilder(string directoryPath){
            this.directoryPath=directoryPath;
        }

        public void DirectoryFiles()
        {
            // Check if the directory exists
            if (!Directory.Exists(this.directoryPath))
            {
                throw new DirectoryNotFoundException($"Directory not found: {this.directoryPath}");
            }

            // Get the files in the directory
            files = Directory.GetFiles(this.directoryPath).ToList();

        }


    }
}