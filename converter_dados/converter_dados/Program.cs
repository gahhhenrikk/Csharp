using System;

//PROGRAMA CONVERTE INT EM STRING (TEXTO EM NUMERO)

namespace converter_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "10";
            int i;

            i = int.Parse(s); //converte int em string (nome da variavel que no caso é 's')

            int x = i + 10; //10 + 10 (pois o i vai virar 10)
            Console.WriteLine(x);

            Console.Read();
        }
    }
}