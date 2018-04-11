using System;

namespace PrimeiroGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis para guardar os valores
            //que o usuário entrará
        double valor1,valor2,resultado;
       Console.WriteLine("Digite um valor");
       valor1 = double.Parse(Console.ReadLine());

       Console.WriteLine("Entre com outro valor");
       valor2 = double.Parse(Console.ReadLine());
        resultado = valor1+valor2;
        
        }
    }
}
