using System.IO;
using System.Drawing;
using System.Collections.Generic;
    public class FileList
    {
        private static List <FileElements>checkedElements = new List<FileElements>();
        private static FileElements[] files;
        private static Panel filePanel;
        public static int someElementIsActive;
        private static int currentAppearFile = 0;
        private static int maxFillesCount = 12;
        private static int list = 1;

        public static void setPanel(FileElements[] receiveFiles,Panel receiveFilePanel)
        {
                files = receiveFiles;
                filePanel = receiveFilePanel;
                currentAppearFile = 0;
                maxFillesCount = 12;
        }
        public static void show()
            {
                filePanel.Controls.Clear();
                int y = -25;
                while(currentAppearFile < maxFillesCount && currentAppearFile < files.Length)
                {
                    FileElements element = files[currentAppearFile];
                    element.fileLabel.Location = new Point(0,y+=25);
                    filePanel.Controls.Add(element.fileLabel);
                    currentAppearFile++;
                }
                /*foreach (FileElements element in files)
                {
                    MessageBox.Show(element.fileLabel.Name);
                    element.fileLabel.Location = new Point(0,y+=25);
                    filePanel.Controls.Add(element.fileLabel);
                }*/
            }
        public static void CheckElement(object sender,EventArgs e)
        { 
            Label checkedLabel = (Label) sender;
            int fileElementID = Int32.Parse(checkedLabel.Name);

            if (checkedLabel.BackColor == Color.Gray)
            {
                checkedElements.Remove(files[fileElementID]);
                checkedLabel.BackColor = Color.Transparent;
            }
            else
            { 
                checkedElements.Add(files[fileElementID]);
                checkedLabel.BackColor = Color.Gray;
            }
            someElementIsActive = checkedElements.Count;
            menu.OptionStatus();
        }
        public static List <FileElements> GetCheckedElements()
        {
            return checkedElements;
        }

        public static void changeListLevel(object sender)
        { 
            string side;
            Button arrow = (Button)sender;
            switch (arrow.Name)
            {
                case "FileLeftArrow":
                    if(currentAppearFile > 12 )
                    { 
                        currentAppearFile -= (12+(12-(12*list - currentAppearFile)));
                        maxFillesCount -= 12;
                        list--;
                        show();
                    }
                break;

                case "FileRightArrow":
                    if(maxFillesCount < files.Length)
                    {
                        maxFillesCount = maxFillesCount + 12;
                        list++;
                        show();
                    }
                break;
            } 
        }

    }

