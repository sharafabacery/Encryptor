using System;
namespace Encryptor
{
    class DirectoryBuilder{
            public string DirectoryPath{set;get;}
            public List<string>files;

     public  void DirectoryFiles(string DirectoryPath)
    {
        // Check if the directory exists
        if (!Directory.Exists(DirectoryPath))
        {
            throw new DirectoryNotFoundException($"Directory not found: {DirectoryPath}");
        }

        // Get the files in the directory
        files = Directory.GetFiles(DirectoryPath).ToList();

        // Check if any files exist
       
    }

            
    }
}