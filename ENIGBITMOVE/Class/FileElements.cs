using System.IO;
using System;

    public class FileElements
    {
        public FileInfo physicalFile { get; set; }
        public Label fileLabel { get; set; }
        public int id { get; set; }
        FileElements(FileInfo physicalFile, int index)
        {
            this.id = index;
            this.physicalFile = physicalFile;
            CreateLabel();
        }
        private void CreateLabel()
        {
            fileLabel = new Label();
            fileLabel.Name = this.id.ToString();
            fileLabel.Text = physicalFile.Name;
            fileLabel.Width = 213;
            fileLabel.Click += new EventHandler(FileList.CheckElement);
        }

        public static FileElements[] CreateFileElements(FileInfo[] userElements)
        {
            FileElements[] elements = new FileElements[userElements.Length];
            int index = 0;
            foreach(FileInfo file in userElements)
            {
                elements[index] = new FileElements(file,index);
                index++;
            }
            return elements;
        }

        public static bool isEBM(FileElements element)
        { 
            bool CONDITION;
            string fileExtension;
            fileExtension = Path.GetExtension(element.physicalFile.FullName);
            if(fileExtension == ".ebm")
            {
                CONDITION = true;
            }
            else
            { 
                CONDITION = false;
            }
            return CONDITION;
            
        }

    }

