using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, mas esta acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos, não pode entrar.");
                }

            }

            Console.ReadLine();
        }
    }
}
