using System.Linq;

namespace DojoCodeApp4
{
    //Desenvolva um programa que dado um valor monetário, seja retornado o valor em reais por extenso.
    public class Class1
    {
        public string ConvertNumberToWords(double number)
        {
            var word = "";
            if (number < 1)
            {
                var centsInt = number * 100;
                ConvertCents((int)centsInt, ref word);
            }
            else
            {
                var cents = number - (int)number;
                var centsInt = cents * 100;
                centsInt = Math.Round(centsInt);

                ConvertReals((int)number, ref word);
                if(centsInt > 0)
                {
                    word += " e ";
                    ConvertCents((int)centsInt, ref word);
                }  
            }

            return word;
        }

        private void ConvertCents(int number, ref string word)
        {
            foreach (var currentNumber in dict.OrderByDescending(c => c.Key))
            {
                if (number >= currentNumber.Key)
                {
                    word += currentNumber.Value;
                    number -= currentNumber.Key;
                    if (number > 0)
                    {
                        word += " e ";
                        //ConvertCents(number, ref word);
                    }
                    else
                    {
                        word += currentNumber.Key == 1 ? " Centavo" : " Centavos";
                    }
                }
            }
        }

        private void ConvertReals(int number, ref string word)
        {
            foreach(var currentNumber in dict.OrderByDescending(c => c.Key))
            {
                if (number >= currentNumber.Key)
                {
                    word += currentNumber.Value;
                    number -= currentNumber.Key;

                    if (number > 0)
                        word += " e ";

                    else
                    {
                        word += currentNumber.Key == 1 ? " Real" : " Reais";
                    }
                }
            }
        }

        private Dictionary<int, string> dict = new Dictionary<int, string>
        {
            { 1, "Um" } ,
            { 2, "Dois"},
            { 3, "Três"},
            { 4, "Quatro"},
            { 5, "Cinco"},
            { 6, "Seis"},
            { 7, "Sete"},
            { 8, "Oito"},
            { 9, "Nove"},
            { 10, "Dez"},
            { 11, "Onze"},
            { 12, "Doze"},
            { 13, "Treze"},
            { 14, "Quatorze"},
            { 15, "Quinze"},
            { 16, "Dezesseis"},
            { 17, "Dezessete"},
            { 18, "Dezoito"},
            { 19, "Dezenove"},
            { 20, "Vinte"},
            { 30, "Trinta"},
            { 40, "Quarenta" },
            { 50, "Cinquenta" },
            { 60, "Sessenta" },
            { 70, "Setenta" },
            { 80, "Oitenta" },
            { 90, "Noventa" },
            { 100, "Cento" }
        };
    }
}