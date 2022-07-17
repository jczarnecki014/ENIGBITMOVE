
    class key
    {
        private int[] splitedNumberKey { get; set; }
        public key(int[] userKey)
        {
            splitedNumberKey = userKey;
        }
        public static int[] convertKey(string key)
        {
            int[] splitedNumberKey = new int[key.Length];
            for(int i=0; i<key.Length; i++)
            {
                splitedNumberKey[i] = key[i] - '0'; // it was used to convert number as char object into int object
            }
            return splitedNumberKey;
        }
        public bool CheckValidationOfFirstTwoNumbers()
        {
            int a,b;
            a = splitedNumberKey[0];
            b = splitedNumberKey[1];
            return (a+b !=0) ? true : false;
        }
        public bool CheckValidationOfSecondTwoNumbers()
        {
            int a = splitedNumberKey[2];
            return (a != 0) ? true:false;

        }
        public bool CheckValidationOfThirdTwoNumbers()
        { 
            int a,b;
            a = splitedNumberKey[4];
            b = splitedNumberKey[5];
            return (a*b != 0) ? true:false;
        }
        public bool CheckValidationOfFourthTwoNumbers()
        {
            int a,b;
            a = splitedNumberKey[6];
            b = splitedNumberKey[7];
            return (a*(a*b+27) != 0) ? true:false;
        }
        public bool CheckValidationOfFifthTwoNumbers()
        {
            int a,b;
            a = splitedNumberKey[8];
            b = splitedNumberKey[9];
            return (Math.Sqrt(a) * Math.Sqrt(b) >0) ? true : false;
        }
        public bool CheckValidationOfSixthTwoNumbers()
        { 
            int a,b;
            a = splitedNumberKey[10];
            b = splitedNumberKey[11];
            return (a*b != 0) ? true:false;
        }
    }

