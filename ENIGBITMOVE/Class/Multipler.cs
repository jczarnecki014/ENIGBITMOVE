
    class Multipler
    {
        private int Finallymultipler{ get; set; }
        public Multipler(int[] splitedKey)
        { 
            int numbStep1 = splitedKey[0] + splitedKey[1];
            double numbStep2 = Math.Pow(Convert.ToDouble(splitedKey[2]),5);
            int numbStep3 = splitedKey[4] * splitedKey[5];
            int numbStep4 = splitedKey[6] * (splitedKey[6] * splitedKey[7] + 27);
            double numbStep5 = Math.Floor(Math.Sqrt(splitedKey[8]) * Math.Sqrt(splitedKey[9]));
            double numbStep6 = Math.Floor(Math.Pow(splitedKey[10] * splitedKey[11], (1/(splitedKey[0] * splitedKey[1]))*2));
            double multipler = (numbStep1 + numbStep2 + numbStep3 + numbStep4 + numbStep5) * (numbStep6+1);
            Finallymultipler = Convert.ToInt32(multipler);
        }

        public int getMultipler()
        {
            return Finallymultipler;
        }
    }

