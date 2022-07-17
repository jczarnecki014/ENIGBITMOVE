

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
                EncryptedChars[iterator] = splitedText[iterator] * multipler;
                iterator++;
            }
        }
        private static int CreateMultiplier()
        {
            int numbStep1 = splitedKey[0] + splitedKey[1];
            double numbStep2 = Math.Pow(Convert.ToDouble(splitedKey[2]),5);
            int numbStep3 = splitedKey[4] * splitedKey[5];
            int numbStep4 = splitedKey[6] * (splitedKey[6] * splitedKey[7] + 27);
            double numbStep5 = Math.Floor(Math.Sqrt(splitedKey[8]) * Math.Sqrt(splitedKey[9]));
            double numbStep6 = Math.Floor(Math.Pow(splitedKey[10] * splitedKey[11], (1/(splitedKey[0] * splitedKey[1]))*2));
            double multipler = (numbStep1 + numbStep2 + numbStep3 + numbStep4 + numbStep5) * (numbStep6+1);
            int FinallyMultipler = Convert.ToInt32(multipler);
            return FinallyMultipler;

        }
        public static int[] start(string fileValue, int[] key)
        { 
            SetSplitedText(fileValue);
            SetSplitedKey(key);
            int multipler = CreateMultiplier();
            EncryptionStepOne(multipler);
            return EncryptedChars;
        } 
    }

