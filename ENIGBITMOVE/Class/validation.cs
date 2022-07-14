


    class validation
    {
        public static void StartValidationOfMenu()
        {
            bool OptionCorrect = menu.CheckValidationOfOption();
            bool MaskCorrect = menu.CheckValidationOfMask();
            bool KeyCorrect = menu.CheckValidationOfKey();
            EnigConsole.WriteLine("START CHECKING THE CORRECTNESS OF FILLING IN THE MENU...");
            EnigConsole.WriteLine("CHECKING VALIDATION THE OPTIONS..");
            EnigConsole.WriteLine("[MENU] CHECKING OPTIONS...: " + OptionCorrect);
            EnigConsole.WriteLine("[MENU] CHECKING MASK...: " + MaskCorrect);
            EnigConsole.WriteLine("[MENU] CHECKING KEY...: " + KeyCorrect);
            if(OptionCorrect && MaskCorrect && KeyCorrect)
            {
                EnigConsole.SetFontColor(Color.Green);
                EnigConsole.WriteLine("[SUCCES]THE MENU VALIDATION WAS SUCCESFUL 3/3 REQUIRED FIELDS WAS CORECTLY COMPLETED ");
                EnigConsole.SetFontColor(Color.White);
            }
            else
            {
                EnigConsole.SetFontColor(Color.Red);
                EnigConsole.WriteLine($"[ValidationException] ONE OR MORE FIELDS WAS INCORRECTLY FILL. PLEASE RUN AGAIN ENIGBITMOVE AND FILL");
                EnigConsole.WriteLine("EVERY FIELDS CORRECTLY");
                EnigConsole.SetFontColor(Color.White);
                throw new ValidationException("ONE OR MORE FIELDS WAS INCORRECTLY FILL");
            }
        }
    }

