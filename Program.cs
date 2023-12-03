using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While__Validador_de_Senha__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================Bem vindo ao programa===========================");
            
            string senha;

            do
            {
                Console.Write("Digite uma senha de (pelo menos 8 caracteres incluindo letras simbolos e numeros): ");
                senha = Console.ReadLine();
            } while (senha.Length < 8);

            Console.Write("Digite a senha para validar: ");
            string senhaValidacao = Console.ReadLine();

            if (senha == senhaValidacao)
            {
                Console.WriteLine("Senha correta!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
    }
}
    
