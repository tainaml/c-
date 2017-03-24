using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroArmazenado;
            int somador = 0;
            int[] numbers = { 3, 1, 5, 8, 2, 1, 10, 3 };
            int[] repeated_number = { };
            

            for (int i = 0; i <= numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i++;
                        j = i + 1;
                    }else
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
            Console.WriteLine($"Total number of duplicate elements found in the array is : {somador}");
            Console.ReadLine();

        }
    }
}
