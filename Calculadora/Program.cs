using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Bem vinda a sua calculadora!");
            Console.WriteLine("Deseja utilizar sua calculadora agora? \n" +
                "0 - Não \n" +
                "1 - Sim");
            int onoff = int.Parse(Console.ReadLine());

            if (onoff == 1)
            {
                Console.WriteLine("Olá, Mallu!");
                do
                {
                    Console.WriteLine("Qual operação deseja realizar? \n" +
                        "1 - Soma \n" +
                        "2 - Subtração \n" +
                        "3 - Divisão \n" +
                        "4 - Multiplicação");
                    int opcoes = int.Parse(Console.ReadLine());
                    switch (opcoes)
                    {
                        case 1:
                            Console.WriteLine("Entre com um valor: ");
                            int x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com outro valor: ");
                            int x2 = int.Parse(Console.ReadLine());

                            int soma = Soma(x1, x2);
                            Console.WriteLine($"O resultado dessa soma é: {soma}.");
                            break;
                        case 2:
                            Console.WriteLine("Entre com um valor: ");
                            x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com outro valor: ");
                            x2 = int.Parse(Console.ReadLine());

                            int subtracao = Subtracao(x1, x2);
                            Console.WriteLine($"O resultado dessa subtração é: {subtracao}");
                            break;
                        case 3:
                            Console.WriteLine("Entre com um valor: ");
                            x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com outro valor: ");
                            x2 = int.Parse(Console.ReadLine());

                            int dividir = Dividir(x1, x2);
                            Console.WriteLine($"O resultado dessa divisão é: {dividir}.");
                            break;
                        case 4:
                            Console.WriteLine("Entre com um valor: ");
                            x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com outro valor: ");
                            x2 = int.Parse(Console.ReadLine());

                            int multiplicacao = Multiplicacao(x1, x2);
                            Console.WriteLine($"O resultado dessa multiplicação é: {multiplicacao}.");
                            break;
                        default:
                            Console.WriteLine("Entre com uma opção válida!");
                            break;
                    }
                    Console.WriteLine("Deseja realizar outra operação? \n" +
                        "0 - Não \n" +
                        "1 - Sim");
                    cont = int.Parse(Console.ReadLine());
                }
                while (cont != 0);
                Console.WriteLine("Até a próxima!");
            }
            else
            {
                Console.WriteLine("Até a próxima!");
            }
        }
        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Dividir(int dividendo, int divisor)
        {
            if (DiferenteDeZero(divisor))
            {
                throw new Exception("Divisor não pode ser 0!");
            }

            return dividendo / divisor;

            bool DiferenteDeZero(int divisor)
            {
                if (divisor == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int Multiplicacao(int num1, int num2)
        {
            return num1*num2;
        }
    }
}
