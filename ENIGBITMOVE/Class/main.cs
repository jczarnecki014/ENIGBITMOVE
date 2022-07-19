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

                EnigConsole.SetFontColor(Color.AliceBlue);
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
                    EnigConsole.WriteLine("SUCESS, EVERY FILES WAS ENCRYPTED");
                }

                else if(menu.GetUserOption() == "decrypt")
                {
                    foreach(FileElements element in choosedFiles)
                    {
                        if(FileElements.isEBM(element))
                        { 
                            string fileValue = filesIO.getValue(element);
                            string decryptedString = Decryption.start(fileValue,convertedKey);
                            string fileExtension = Decryption.GetExtension();
                            filesIO.saveValue(decryptedString,fileExtension,element);
                        }
                        else
                        {
                            MessageBox.Show($"[{element.physicalFile.FullName}] - is not encrypted yet, so ENIGBITMOVE rejected this file","Attention");
                        }
                        
                    }
                    EnigConsole.WriteLine("SUCESS, EVERY FILES WAS DECRYPTED");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnigConsole.ClearConsole();
                thisForm.Hide();
                menuForm.Show();
            }
            
            
        }
    }

