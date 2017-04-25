using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> nomes = new List<string>();
            int vez = 1;
            while (vez == 1)
            {
                Console.WriteLine("Digite o numero 1 ou 0 ");
                vez =Convert.ToInt16(Console.ReadLine());
                if (vez == 0)
                {
                    break;
                }
                Console.WriteLine("Digite um nome: ");
                string nomeDigitado = Console.ReadLine();
                nomes.Add(nomeDigitado);
            }

            foreach (var nome in nomes) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("A lista tem: " + nomes.Count);
            
            Console.ReadLine();
        }
    }
}
