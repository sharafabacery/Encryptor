using System;
using System.Dynamic;
using System.Resources;

namespace Encryptor
{
    class DirectoryNavigator
    {
        
        public List<DirectoryBuilder> Directories{private set;get;}
        public DirectoryNavigator()
        {
            Directories = new List<DirectoryBuilder>();
           
        }
        public void GetDirectory(string directoryPath,Nullable<int> depthLimit){
            this.DFS(directoryPath,depthLimit,0);
        }
        
        private void DFS(string directoryPath,Nullable<int> depthLimit,int currentDepth)
        {
            // Check if the directory exists
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"Directory not found: {directoryPath}");
            }
            if(depthLimit is not null&&currentDepth>depthLimit){
                    return;
            }
            DirectoryBuilder directoryBuilder =new DirectoryBuilder(directoryPath);
            directoryBuilder.DirectoryFiles();
            Directories.Add(directoryBuilder);

            // Get the subdirectories in the directory
            string[] subdirectories = Directory.GetDirectories(directoryPath);
            foreach (var item in subdirectories)
            {
                DFS(item,depthLimit,currentDepth+1);
            }

            
        }

    }

}