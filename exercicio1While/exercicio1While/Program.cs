using System;

namespace exercicio1While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, Digite a senha para continuar: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.WriteLine();
                Console.Write("Digite novamente: ");
                Console.WriteLine();
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Acesso Permitido!");
        }
        
    }

}
