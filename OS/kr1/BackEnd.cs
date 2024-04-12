using System;
using System.IO;


namespace kr1
{
    class FileStreamBased
    {
        public void Combine(string inputDir, string outputFilePath, string mask, string format)
        {
            using (FileStream outputFileStream = File.Create(outputFilePath))
            {
                DirectoryInfo dr = new DirectoryInfo(inputDir);
                foreach (FileInfo file in dr.GetFiles(mask + "*.*"))
                {
                    /*if (format == "byte")
                        using (FileStream partitionFileStream = File.ReadAllBytes)
                        { partitionFileStream.CopyTo(outputFileStream); }*/
                    //if (format == "char")
                        using (FileStream partitionFileStream = file.OpenRead())
                        { partitionFileStream.CopyTo(outputFileStream); }
                }
            }
        }
    }
}