using System;
namespace Encryptor
{
    class DirectoryNavigator{
        public string TargetDirectory{get;set;}
        public List<string>directories;
        public DirectoryNavigator(){
            directories=new List<string>();
        }
        public void DirectoryHasSubdirectories(string directoryPath)
    {
        // Check if the directory exists
        if (!Directory.Exists(directoryPath))
        {
            throw new DirectoryNotFoundException($"Directory not found: {directoryPath}");
        }
        directories.Add(directoryPath);

        // Get the subdirectories in the directory
        string[] subdirectories = Directory.GetDirectories(directoryPath);
        foreach (var item in subdirectories)
        {
            DirectoryHasSubdirectories(item);
        }

        // Check if any subdirectories exist
    }

    }

}