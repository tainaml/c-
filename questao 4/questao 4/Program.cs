/*
 * Write a program in C# Sharp to copy the elements one array into another array. Go to the editor
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 15 
element - 1 : 10 
element - 2 : 12 
Expected Output : 
The elements stored in the first array are : 
15 10 12 
The elements copied into the second array are : 
15 10 12 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("type the number of elements you want: ");
            int numberOfElements = Convert.ToInt16((Console.ReadLine()));


            int[] a1 = new int[numberOfElements];

            int i = 0;


            while (i < numberOfElements)
            {

                Console.WriteLine("choose a type to add: ");
                int x = Convert.ToInt16(Console.ReadLine());
                a1[i] = x;
                i++;
            }


            Console.Write("The values store into the array are: ");
            foreach (var numeros in a1)
            {
                Console.Write($"{numeros} ", "\n");
            }


            int[] a2 = new int[numberOfElements];

            Array.Copy(a1, a2, numberOfElements);

            Console.Write("\nAnd in the 2nd array : ");
            foreach (var n in a2)
            {
                Console.Write($"{n} ");
            }

            Console.ReadKey();

        }
    }
}
