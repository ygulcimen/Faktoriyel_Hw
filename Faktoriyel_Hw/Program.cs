using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktoriyel hesaplama için pozitif bir sayı giriniz: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sonuc = Factorial(input);
            Console.WriteLine("Girdiğiniz sayının faktöriyeli: " + sonuc);
            Console.ReadLine();
        }
        static int Factorial(int number)
        {
            int result = number;
            if (number == 1 || number == 0)
            {
                result = 1;

            }
            else
            {
                for (int i = number - 1; i > 0; i--)
                {
                    result = result * i;

                }
                
            }


            return result;
        }
    }
}
