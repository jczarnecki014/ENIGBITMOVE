
    abstract class filesIO
    {
        private const string separator = "  ";
        public static string getValue(FileElements element)
        {
            FileInfo file = element.physicalFile;
            StreamReader newSession = new StreamReader(file.OpenRead());
            string fileValue = newSession.ReadToEnd();
            newSession.Close();
            return fileValue;
        }
        public static void saveValue(int[] encrypt, FileElements file)
        { 
            FileInfo newFile = new FileInfo(file.physicalFile.DirectoryName+"\\"+Path.GetFileNameWithoutExtension(file.physicalFile.FullName)+".ebm");
            FileStream plik = newFile.Create();
            StreamWriter newSession = new StreamWriter(plik);
            foreach (int c in encrypt)
            {
                newSession.Write($"{c}{separator}");
            }
            newSession.Write(Path.GetExtension(file.physicalFile.FullName));
            newSession.Close();
        }
        public static void saveValue(string decrypt, string extension, FileElements file)
        {
            FileInfo newFile = new FileInfo(file.physicalFile.DirectoryName+"\\"+Path.GetFileNameWithoutExtension(file.physicalFile.FullName)+extension);
            FileStream plik = newFile.Create();
            StreamWriter newSession = new StreamWriter(plik);
            newSession.Write(decrypt);
            newSession.Close();
        }
}

