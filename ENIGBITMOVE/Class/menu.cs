


    class menu
    {
        private static int enable;

        private static RadioButton EncryptButton;
        private static RadioButton DecryptButton;
        private static TextBox Mask;
        private static TextBox KeyInput;
        private static Button RunButton;

        public static void LoadMenuElements(RadioButton reciveEncryptButton, RadioButton reciveDecryptButton, 
                                            TextBox reciveMask, TextBox reciveKeyInput, Button reciveRunButton)
        {
            EncryptButton = reciveEncryptButton;
            DecryptButton = reciveDecryptButton;
            Mask = reciveMask;
            KeyInput = reciveKeyInput;
            RunButton = reciveRunButton;
        }

        public static void OptionStatus()
        { 
            enable = FileList.someElementIsActive;
            if(enable > 0 )
            {
                EncryptButton.Enabled = true;
                DecryptButton.Enabled = true;
                Mask.Enabled = true;
                KeyInput.Enabled = true;
                RunButton.Enabled = true;
            }
            else
            { 
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = false;
                Mask.Enabled = false;
                KeyInput.Enabled = false;
                RunButton.Enabled = false;
            }
        }
        public static bool CheckValidationOfOption()
        { 
            if(EncryptButton.Checked || DecryptButton.Checked){
                 return true;
            }
            else{
                return false;
            }
        }
        public static bool CheckValidationOfMask()
        {
            try
            {
                Int32.Parse(Mask.Text);
            }
            catch (FormatException)
            {
                return false;
            }
                return true;
        }
        public static bool CheckValidationOfKey()
        {
           if(KeyInput.Text.Length < 12)
           {
                return false;
           }
           try
            {
                Int64.Parse(KeyInput.Text);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
        public static string GetUserOption()
        { 
            if(EncryptButton.Checked)
            {
                return "encrypt";
            }
            else if(DecryptButton.Checked)
            {
                return "decrypt";
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }
        public static string GetUserMask()
        {
            return Mask.Text;
        }
        public static string GetUserKey()
        {
            return KeyInput.Text;
        }

    }

