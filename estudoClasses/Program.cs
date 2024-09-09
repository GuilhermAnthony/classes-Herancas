using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa();
            Funcionario f1 = new Funcionario();

            p1.cadastrar();
            p1.mostrarDados();

            f1.cadastrar();
            f1.mostrarDados();
            
            Console.ReadKey();
        }
    }
}
