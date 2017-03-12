/*
 * 
3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor
Test Data : 
Input the number of elements to be stored in the array :3 
Input 3 elements in the array : 
element - 0 : 2 
element - 1 : 5 
element - 2 : 8 
Expected Output : 
Sum of all elements stored in the array is : 15 


*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("size of the array: ");
            int size = Convert.ToInt16(Console.ReadLine());         
           
            int[] numbers = new int[size];
            
            int somador = 0;

            for(int i=0; i < numbers.Length; i++) 
            {
                Console.WriteLine("choose a value: ");
                int choose = Convert.ToInt16(Console.ReadLine());
                numbers[i] = choose;
                
                    
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
                somador = somador + n;
                
            }
            Console.WriteLine($"Soma total: {somador}");
            Console.ReadLine();

        }
    }
}
