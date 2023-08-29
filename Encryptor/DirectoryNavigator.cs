using System;
namespace Encryptor
{
    class DirectoryNavigator
    {
        
        public List<DirectoryBuilder> Directories{private set;get;}
        public DirectoryNavigator()
        {
            Directories = new List<DirectoryBuilder>();
           
        }
        public void GetSubDirectoriesofDirectory(string directoryPath)
        {
            // Check if the directory exists
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"Directory not found: {directoryPath}");
            }
            DirectoryBuilder directoryBuilder =new DirectoryBuilder(directoryPath);
            directoryBuilder.DirectoryFiles();
            Directories.Add(directoryBuilder);

            // Get the subdirectories in the directory
            string[] subdirectories = Directory.GetDirectories(directoryPath);
            foreach (var item in subdirectories)
            {
                GetSubDirectoriesofDirectory(item);
            }

            
        }

    }

}