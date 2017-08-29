using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string tmp;
            Console.WriteLine("Digite um numero: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite outro numero: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double soma, subtracao, divisao, multiplicacao;
            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;

            Console.WriteLine("A soma dos valores eh: " +soma);
            Console.WriteLine("A subtracao dos valores eh: " + subtracao);
            Console.WriteLine("A divisao dos valores eh: " + divisao);
            Console.WriteLine("A multiplicacao dos valores eh: " + multiplicacao);
            Console.Read();

        }
    }
}