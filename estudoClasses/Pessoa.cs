using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoClasses
{
    internal class Pessoa
    {
        public string nome;
        public string telefone;
        public string cpf;

        public virtual void cadastrar ()
        {
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine ();

            Console.WriteLine("Digite seu telefone:");
            telefone = Console.ReadLine ();

            Console.WriteLine("Digite seu CPF:");
            cpf = Console.ReadLine ();
        }

        public virtual void mostrarDados ()
        {
            Console.WriteLine("CADASTRO BEM SUCEDIDO");
            Console.WriteLine("Nome: {0} \nTelefone: {1} \nCPF: {2}", nome, telefone, cpf);
        }
    }
}
