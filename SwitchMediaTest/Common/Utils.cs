using System;
namespace SwitchMediaTest.Common
{
    static  class Utils
    {
        public static string GenerateName(int len)
        {
            try
            {
                Random r = new Random();
                string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
                string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
                string Name = "";
                Name += consonants[r.Next(consonants.Length)].ToUpper();
                Name += vowels[r.Next(vowels.Length)];
                int b = 2;
                while (b < len)
                {
                    Name += consonants[r.Next(consonants.Length)];
                    b++;
                    Name += vowels[r.Next(vowels.Length)];
                    b++;
                }

                return Name;
            }
            catch(Exception e)
            {
                //record log and error handle

                return string.Empty;
            }
        }
    }
}
