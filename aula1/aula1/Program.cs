using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num2 = 20;
            string texto;
            Console.WriteLine("O valor da soma eh: ");
            Console.WriteLine(num+num2);

            Console.WriteLine("---------------------------------------------------------");

            //replica o que o usuario digitou
            Console.WriteLine("Digite um texto: ");
            texto = Console.ReadLine();
            Console.WriteLine("O valor foi digitado foi: " +texto);
            Console.Read();
        }
    }
}