using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();
            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            int qtd = lista.Count();

            Console.WriteLine(qtd);

            Console.ReadLine();
                




        }
    }
}
