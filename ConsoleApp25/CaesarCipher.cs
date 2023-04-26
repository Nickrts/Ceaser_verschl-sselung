using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public static class CaesarCipher
    {
        static string text = "Lfk elq ghu Vlprq ghu jhuqh Edqdqhq lvvw xqg plw vhlqhp Kxqg vslhow ";

        private const int Offset = 32;


        public static int Encode(char letter)
        {
            letter = char.ToLower(letter);
            return (int)letter - Offset;
        }
        public static char Decode(int code)
        {
            return (char)(code + Offset);
        }

        public static void chtext()
        {
            for (int i = 1; i <= 26; i++)
            {
                Console.Write(i + ": ");
                for (int k = 0; k < text.Length; k++)
                {
                    if (text[k] == ' ') Console.Write(" ");
                    else
                    {
                        int write = Encode(text[k]);
                        for (int l = 0; l< i; l++)
                        {
                            write++;
                            if (write > 90) write = 65;
                        }

                        Console.Write(Decode(write));
                    }

                }

                Console.WriteLine();
            }

        }
    
    }
}
