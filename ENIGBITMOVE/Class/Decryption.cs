
    class Decryption
    {
        private static string[] splitedCode;
        private static int[] splitedKey;
        private static char[] DecryptedChar;
        private static string extension;

        private static void SetSplitedCode(string fileValue)
        { 
            splitedCode = fileValue.Split("  ");
        }
        private static void SetSplitedKey(int[] key)
        {
            splitedKey = key;
        }
        private static void SetExtension()
        { 
            extension = splitedCode[splitedCode.Length-1];
        }
        public static string GetExtension()
        { 
            return extension;
        }

        private static string DecryptionStepOne(int multipler)
        {   
            DecryptedChar = new char[splitedCode.Length-1];
            int iterator = 0;
            int convertedCode;
            while(iterator<(splitedCode.Length-1))
            {
                convertedCode = Int32.Parse(splitedCode[iterator]);
                DecryptedChar[iterator] = Convert.ToChar(convertedCode/multipler);
                iterator++;
            }
            return new string(DecryptedChar);
        }

        public static string start(string fileValue, int[] key)
        { 
            SetSplitedKey(key);
            SetSplitedCode(fileValue);
            SetExtension();
            int multipler = new Multipler(splitedKey).getMultipler();
            string DecryptedText = DecryptionStepOne(multipler);
            return DecryptedText;
        } 
    }

