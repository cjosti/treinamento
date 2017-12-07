using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1.Model;

namespace Aula1
{
    class Program
    {
        public static void Print(object o)
        {
            Console.WriteLine(o.ToString());
        }

        public static void Show(Local local)
        {
            Console.WriteLine("{0} - {1}", local.Code, local.Size);
            local.Harvest();
        }

        static void Main(string[] args)
        {
            int i = 10;
            bool b = false;
            string s = "Osti";
            Print(i);
            Print(b);
            Print(s);

            Sector sectorA = new Sector("S1",100);
            Show(sectorA);

            Farm farm1 = new Farm();
            farm1.Code = "f1";

            Block block1 = new Block();
            block1.Code = "b1";
            block1.Size = 50;

            Field field = new Field();
            field.Code = "f1";
            field.Size = 10;
            field.Culture = "Sugar Cane";

            Show(sectorA);
            Show(farm1);
            Show(block1);
            Show(field);
            
            //Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
