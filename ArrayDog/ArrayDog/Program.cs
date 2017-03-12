using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDog
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog[] array = new Dog[10]
            {
                new Dog() {numero = 1 },
                new Dog() {numero = 1 },
                new Dog() {numero = 2 },
                new Dog() {numero = 3 },
                new Dog() {numero = 4 },
                new Dog() {numero = 5 },
                new Dog() {numero = 6 },
                new Dog() {numero = 7 },
                new Dog() {numero = 8 },
                new Dog() {numero = 9 },

            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"posicao: {i} e o valor: {array[i].numero}");
            }



            Console.Read();
        }
    }
}