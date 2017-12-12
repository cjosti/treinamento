using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula2.Model;

namespace Aula2
{
    class Program
    {

        static void ImprimirExtrato(Conta c)
        {
            //Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("------------Imprimindo Extrato------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" Agencia: {c.Agencia}   Conta: {c.Numero}");
            Console.WriteLine("------------------------------------------");

            Item[] extrato = c.ObterExtrato();

            foreach(Item item in extrato)
            {
                if (item.Valor < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                { 
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
                Console.WriteLine(item);   
            }            
        }

        static void Main(string[] args)
        {
            Conta c = new ContaCorrente(1201, 0012345);
            
            c.Depositar(100m);
            c.Sacar(50m); 
            c.Depositar(150m);
            c.Sacar(10m); 

            ImprimirExtrato(c);

            Console.ReadKey();
        }
    }
}
