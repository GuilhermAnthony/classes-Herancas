using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoClasses
{
    internal class Funcionario:Pessoa
    {
        public int registro;
        public string departamento;
        public double salario;

        public override void cadastrar()
        {
            base.cadastrar();

            Console.WriteLine("Digite o registro:");
            registro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o departamento:");
            departamento = Console.ReadLine();

            Console.WriteLine("Digite o salario:");
            salario = double.Parse(Console.ReadLine());
        }

        public override void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Nº de registro: {0} \nDepartamento: {1} \nSalario Bruto: {2}", registro, departamento, salario);
        }
    }
}
