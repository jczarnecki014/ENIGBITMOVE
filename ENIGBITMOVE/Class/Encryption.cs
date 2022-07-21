

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
            int maskNumber = menu.GetUserMask();
            Random random = new Random();
            EncryptedChars = new int[splitedText.Length + (splitedText.Length * maskNumber)];
            int EncryptedIterator = 0;
            int MaskIterator = 0;
            int SplitedIterator =0;
            while(SplitedIterator < splitedText.Length)
            {
                if(MaskIterator % maskNumber == 0 && MaskIterator != 0)
                {
                    SplitedIterator++;
                    MaskIterator =0;
                }
                else
                {
                    EncryptedChars[EncryptedIterator] = Math.Abs(random.Next(10,99)*multipler);
                    MaskIterator++;
                }
                EncryptedIterator++;
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

