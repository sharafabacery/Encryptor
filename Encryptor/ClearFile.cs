using System;

namespace Encryptor
{
    public static class ClearFile{
        public static void ClearFileFunction(string filePath)
    {
        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            fileStream.Seek(0, SeekOrigin.Begin);
            fileStream.SetLength(0);
        }
    }
    }
    
}