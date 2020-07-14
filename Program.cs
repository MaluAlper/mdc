using System;

namespace mdc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int dividendo;
            int divisor;
            int resto;

            Console.Clear();

            Console.WriteLine("Máximo Divisor Comum (MDC)");
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 0 || n2 == 0)
            {
                Console.WriteLine("Não pode haver valores = 0");
                Environment.Exit(-1);
            }

            if (n1 > n2)
            {
                dividendo = n1;
                divisor = n2;
            }

            else
            {
                dividendo = n2;
                divisor = n1;
            }
            while (dividendo % divisor != 0)
            {
                resto = dividendo % divisor;
                dividendo = divisor;
                divisor = resto;
            }
            Console.WriteLine("MDC= " + divisor);




        }
    }
}
