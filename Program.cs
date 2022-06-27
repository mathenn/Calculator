using System;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione o cálculo que você deseja fazer:");
            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair da calculadora :(");

            Console.WriteLine("");
            Console.WriteLine("---------------------------");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Você acessou a opção: Soma");
            Console.WriteLine("");

            Console.WriteLine("Digite o valor a ser somado:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o  valor a somar:");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 + valor2;

            Console.WriteLine($"O resultado de {valor1} somado por {valor2} é {resultado}.");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Você acessou a opção: Subtração");
            Console.WriteLine("");

            Console.WriteLine("Digite o valor a ser subtraído:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o  valor a subtrair:");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 - valor2;

            Console.WriteLine($"O resultado de {valor1} subtraído por {valor2} é {resultado}.");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Você acessou a opçao: Divisão");
            Console.WriteLine("");

            Console.WriteLine("Digite o valor a ser dividido:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a dividir:");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine($"O resultado de {valor1} dividido por {valor2} é {resultado}.");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor a ser multiplicado:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a multiplicar:");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.WriteLine($"O resultado de {valor1} multiplicado por {valor2} é {resultado}.");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Obrigado por usar a calculadora!");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
        }
    }
}