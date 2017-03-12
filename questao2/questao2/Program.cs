/*2. Write a program in C# Sharp to read n number of values in an array and display 
it in reverse order. Go to the editor
Test Data : 
Input the number of elements to store in the array :3  ok
Input 3 number of elements in the array : 
element - 0 : 2 
element - 1 : 5 
element - 2 : 7 
Expected Output : 
The values store into the array are : 
2 5 7 
The values store into the array in reverse are : 
7 5 2 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
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
                a1[i]  = x;
                i++;               
            }

            
            Console.Write("The values store into the array are: ");
                foreach (var numeros in a1)
            {
                Console.Write($"{numeros} " ,"\n");
            }


            Array.Reverse(a1);

            Console.Write("\nThe values in reverse are: ");
                foreach (var numeros in a1)
            {
                Console.Write($"{numeros} ","\n");
            };

                                
            Console.ReadKey();

            
        }
    }
}


