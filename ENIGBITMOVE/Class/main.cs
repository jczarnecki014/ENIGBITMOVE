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
                validation.StartValidationOfMenu();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
                EnigConsole.ClearConsole();
                thisForm.Close();
                menuForm.Show();
            }
            
        }
    }

