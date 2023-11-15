using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
using consulta;
using Pessoa;
*/
namespace clinicaDentario_23005
{
     class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("" + p1.ToString());
            Console.WriteLine("" + p2.ToString());
            Console.WriteLine("" + p3.ToString());

            Console.ReadKey();  
        }
    }
}
