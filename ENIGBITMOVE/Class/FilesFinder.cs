using System;
using System.IO;




    public class FilesFinder
    {
         DirectoryInfo userDirectory { set; get; }
        public FilesFinder(string Path)
        {
            FindDirectory(Path);
        }
        private void FindDirectory(string Path)
        {
            try
            {
                userDirectory = new DirectoryInfo(Path);
            }
            catch (ArgumentException)
            {
                userDirectory = new DirectoryInfo("NULL_PATH");
            }
            
        }
        public FileInfo[] ReturnFiles()
        {
            if(this.userDirectory.Exists)
            { 
                return this.userDirectory.GetFiles();
            }
            else
            {
                throw new DirectoryNotFoundException();
            }
        }

    }

