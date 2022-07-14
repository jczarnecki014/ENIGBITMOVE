using System.IO;
namespace ENIGBITMOVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menu.LoadMenuElements(EncryptButton,DecryptButton,Mask,KeyInput,RunButton);
        }


        private void FindButton_LoadUserFiles(object sender, EventArgs e)
        {
            string FilesLocationPath = this.FilesLocation.Text;

            FilesFinder FileSearch = new FilesFinder(FilesLocationPath);
            try
            {
                FileInfo[] userFiles = FileSearch.ReturnFiles();
                FileElements[] elementsForPanel = FileElements.CreateFileElements(userFiles);
                FileList.setPanel(elementsForPanel,FilesListPanel);
                FileList.show();
             }
            catch (DirectoryNotFoundException)
            { 
                MessageBox.Show("I didn't found directory with that name");
            }
            
        }

        private void FileLeftArrow_Click(object sender, EventArgs e)
        {
            FileList.changeListLevel(sender);
        }

        private void FileRightArrow_Click(object sender, EventArgs e)
        {
            FileList.changeListLevel(sender);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{menu.CheckValidationOfMenu()}");
            menu.GetAllYouserChoice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This project is only concept and my skill presentation, and it shouldn't be used in real encryptions","WARNING !");
        }
    }
}