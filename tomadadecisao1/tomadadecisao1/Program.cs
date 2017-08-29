using System;

namespace tomadadecisao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;


            Console.WriteLine("Digite um numero");
            string str = Console.ReadLine();
            num = Convert.ToInt32(str);

            if(num > 0)
            {
                Console.WriteLine("Numero positivo");
            }else
            {
                Console.WriteLine("Numero negativo");
            }

            Console.Read();
        }
    }
}