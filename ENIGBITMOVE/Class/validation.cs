


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
        public static void StartValidationOfEncryption(key obj)
        {
          EnigConsole.WriteLine("START CHECKING THE KEY CORRECTNES...");
          EnigConsole.SetFontColor(Color.Gray);
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 1] CORRECTNESS: " + obj.CheckValidationOfFirstTwoNumbers());
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 2] CORRECTNESS: " + obj.CheckValidationOfSecondTwoNumbers());
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 3] CORRECTNESS: " + obj.CheckValidationOfThirdTwoNumbers());
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 4] CORRECTNESS: " + obj.CheckValidationOfFourthTwoNumbers());
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 5] CORRECTNESS: " + obj.CheckValidationOfFifthTwoNumbers());
          EnigConsole.WriteLine("[KEY]VERYFICATION[KEY][STEP 5] CORRECTNESS: " + obj.CheckValidationOfSixthTwoNumbers());
          if(obj.CheckValidationOfFirstTwoNumbers() && obj.CheckValidationOfSecondTwoNumbers() && obj.CheckValidationOfThirdTwoNumbers()
          && obj.CheckValidationOfFourthTwoNumbers() && obj.CheckValidationOfFifthTwoNumbers() && obj.CheckValidationOfSixthTwoNumbers())
          {
                EnigConsole.SetFontColor(Color.Green);
                EnigConsole.WriteLine("[SUCCES]THE KEY VERYFICATION WAS SUCCES, EVERY NUMBER WAS ACCEPT BY SYSTEM 6/6");
                EnigConsole.WriteLine("VALIDATION WAS FOUND OK");
                EnigConsole.SetFontColor(Color.White);
          }
          else
          {
                EnigConsole.SetFontColor(Color.Red);
                EnigConsole.WriteLine($"[ValidationException] SOMETHING WENT WRONG.. KEY WAS REJCTED !! PLEASE TRY AGAIN BUT");
                EnigConsole.WriteLine("DON'T USE 0 DURING TYPE CODE, 0 CAN CAUSE THIS PROBLEM");
                EnigConsole.SetFontColor(Color.White);
                throw new ValidationException("KEY WAS REJECTED, PLEAS DON'T USE '0' DURING KEY TYPING");
          }
        }
    }

