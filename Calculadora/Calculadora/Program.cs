using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("Escolha a operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                
                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 4)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    continue;
                }
                
                if (opcao == 0) break;
                
                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.ReadKey();
                    continue;
                }
                
                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.ReadKey();
                    continue;
                }
                
                double resultado = 0;
                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: divisão por zero!");
                            Console.ReadKey();
                            continue;
                        }
                        resultado = num1 / num2;
                        break;
                }
                
                Console.WriteLine($"Resultado: {resultado}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
