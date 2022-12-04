using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object t = "";
            object t2 = 123345;

            var v1 = "";
            var v2 = 123345;
            // ERRO: var v3;
            //ERRO> V2 = "";


            dynamic d1 = new Usuario { Nome = "Maria" };


            Console.WriteLine(d1.Nome);
           // Console.WriteLine(d1.Senha);

            d1 = "";

        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
