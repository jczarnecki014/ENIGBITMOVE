
    abstract class filesIO
    {
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
                newSession.Write($"{c}  ");
            }
            newSession.Write(Path.GetExtension(file.physicalFile.FullName));
            newSession.Close();
    }
}

