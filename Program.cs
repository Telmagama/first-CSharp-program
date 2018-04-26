using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracteres e Textos");

            char primeiraLetra = 'a';

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);     // type casting
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = 
@"- .NET
- JAVA 
- JAVASCRIPT";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);



            Console.WriteLine("clique em enter para fechar!");

            Console.ReadLine();

        }
    }
}
