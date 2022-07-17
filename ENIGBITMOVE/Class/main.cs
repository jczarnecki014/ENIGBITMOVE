using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class main
    {
        public static void runProgram(Form thisForm, Form menuForm)
        { 
            try
            {
                int[] convertedKey = key.convertKey(menu.GetUserKey());
                validation.StartValidationOfMenu();
                validation.StartValidationOfKey(new key(convertedKey));
                List <FileElements> choosedFiles = FileList.GetCheckedElements();

                if(menu.GetUserOption() == "encrypt")
                { 
                    foreach(FileElements element in choosedFiles)
                    {
                        if(!FileElements.isEBM(element))
                        { 
                            string fileValue = filesIO.getValue(element);
                            int[] encryptedChars = Encryption.start(fileValue,convertedKey);
                            filesIO.saveValue(encryptedChars,element);
                        }
                        else
                        {
                            MessageBox.Show($"[{element.physicalFile.FullName}] - is encrypted yet, so ENIGBITMOVE rejected this file","Attention");
                        }
                    }
                }
                else if(menu.GetUserOption() == "decrypt")
                {
                    foreach(FileElements element in choosedFiles)
                    {
                        
                    }
                }
                
                EnigConsole.SetFontColor(Color.AliceBlue);
                EnigConsole.WriteLine("SUCESS, EVERY FILES WAS ENCRYPTED");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnigConsole.ClearConsole();
                thisForm.Close();
                menuForm.Show();
            }
            
            
        }
    }

