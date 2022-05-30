using System;
using System.Linq;

namespace Obliczanie_liczby_kontrolnej_EAN_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string ean13; //EAN-13 code setted by user.
            int[] singleNumbers = new int[13]; //Array of single numbers in EAN-13 code.
            int sum = 0; //Sum needed to calculate check number.
            int multipleOfTen = 10; //Int used to represents multiple of ten.
            Console.WriteLine("Podaj numer EAN-13: ");
            while (true)
            {
                ean13 = Console.ReadLine(); //Gets EAN-13 code from user.
                Console.Clear();
                if ((ean13.Length == 13) && ean13.All(char.IsDigit)) //Checks if code is coorest length and is numeric.
                {
                    break;
                }
                Console.WriteLine("Nieprawidlowy numer EAN-13!\nSprobuj jeszcze raz: ");
            }
            for (int i = 0; i < 12; i++) //Calculates sum
            {
                if (i % 2 == 0) { sum += ToInt(ean13[i]); }
                else { sum += (ToInt(ean13[i]) * 3); }
            }
            while (multipleOfTen <= sum) { multipleOfTen += 10; } //Shows programs result.
            if (multipleOfTen - sum == ToInt(ean13[12]))
            {
                Console.WriteLine("Poprawna liczba kontrolna!");
            }
            else
            {
                Console.WriteLine("Nieporpawna liczba kontolna!");
            }

        }

        /// <summary>
        /// Converts char to int.
        /// </summary>
        /// <param name="c">char</param>
        /// <returns>int</returns>
        static int ToInt(char c)
        {
            return (int)(c - '0');
        }
    }
}
