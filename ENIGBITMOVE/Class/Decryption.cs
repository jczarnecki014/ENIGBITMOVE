
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
            int mask = menu.GetUserMask();
            int lengthOfArray = (splitedCode.Length - 1) / mask + 1;
            DecryptedChar = new char[lengthOfArray];
            int iteratorInSplitedArray = 0;
            int iteratorInDecryptedArray =0;
            int MaskIterator = 0;
            int convertedCode;
            while(iteratorInSplitedArray<(splitedCode.Length-1))
            {
                
                if(MaskIterator%mask == 0 && MaskIterator != 0)
                {
                    convertedCode = Int32.Parse(splitedCode[iteratorInSplitedArray]);
                    DecryptedChar[iteratorInDecryptedArray] = Convert.ToChar(convertedCode/multipler);
                    iteratorInDecryptedArray++;
                    MaskIterator =0;

                }
                else
                {
                    MaskIterator++;
                }
                iteratorInSplitedArray++;
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

