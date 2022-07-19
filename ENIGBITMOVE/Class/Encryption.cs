

    class Encryption
    {
        private static char[] splitedText;
        private static int[] splitedKey;
        private static int[] EncryptedChars;
        private static void SetSplitedText(string text)
        {
            splitedText = text.ToCharArray();
        }
        private static void SetSplitedKey(int[] key)
        {
            splitedKey = key;
        }
        private static void EncryptionStepOne(int multipler)
        {   
            EncryptedChars = new int[splitedText.Length];
            int iterator = 0;
            while(iterator < splitedText.Length)
            {
                EncryptedChars[iterator] = Math.Abs(splitedText[iterator] * multipler);
                iterator++;
            }
        }
        public static int[] start(string fileValue, int[] key)
        { 
            SetSplitedText(fileValue);
            SetSplitedKey(key);
            int multipler = new Multipler(splitedKey).getMultipler();
            EncryptionStepOne(multipler);
            return EncryptedChars;
        } 
    }

