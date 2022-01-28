using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_1
{
    class Program
    {
        static void Main(string [] args)
        {  
            string nome;
            double precoFab, precoFinal;

            Console.WriteLine("Qual o nome do automóvel?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o preço de Fábrica?");
            precoFab = Double.Parse(Console.ReadLine());

            precoFinal = precoFab + precoFab *0.45 + precoFab * 0.28;

            Console.WriteLine("O automóvel " + nome + " Custará: "+ precoFinal);
        }
    }
}
