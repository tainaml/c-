/*
Write a program in C# Sharp to count a total number of duplicate elements in an array. Go to the editor
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 5 
element - 1 : 1 
element - 2 : 1 
Expected Output : 
Total number of duplicate elements found in the array is : 1 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroArmazenado;
            int somador = 0;
            int[] numbers = { 3, 1, 5, 8, 2, 1, 10, 3 };

            for (int i = 0; i <= numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numeroArmazenado = numbers[i];
                        somador = somador + 1;
                        Console.WriteLine(numeroArmazenado);
                    }
                }
            }
            Console.WriteLine($"Total number of duplicate elements found in the array is : {somador}");
            Console.ReadLine();

        }
    }
}
