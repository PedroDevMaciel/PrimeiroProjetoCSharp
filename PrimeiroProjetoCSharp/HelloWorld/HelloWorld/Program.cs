using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero1 = "";
            string numero2 = "";

            Console.WriteLine("Digite o primeiro número:\n");
            numero1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo número\n");
            numero2 = Console.ReadLine();

            Console.WriteLine("Escolha a operação abaixo:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Multiplicar");
            Console.WriteLine("3 - Dividir");
            string escolha = Console.ReadLine();

            int a, b;
            if (int.TryParse(numero1, out a) && int.TryParse(numero2, out b))
            {
                switch (escolha)
                {
                    case "1":
                        int soma = a + b;
                        Console.WriteLine($"A soma de {numero1} + {numero2} é de: {soma}");
                        break;
                    case "2":
                        int multiplicação = a * b;
                        Console.WriteLine($"A multiplicação de {numero1} * {numero2} é de: {multiplicação}");
                        break;
                    case "3":
                        if (b != 0)
                        {
                            double quociente = (double)a / b;
                            Console.WriteLine($"A divisão de {numero1} / {numero2} é de: {quociente}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero!");
                        }
                        break;
                    default:
                        Console.WriteLine("Erro: Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro: Os valores inseridos não são números válidos.");
            }

            Console.ReadLine();


        }
    }
}
