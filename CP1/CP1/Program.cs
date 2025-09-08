// Projeto de Avaliação (Revisado) - Variante 4: Mini Calculadora com menu
// O código abaixo deve exibir um menu de operações e executar a escolhida, repetindo até que o usuário deseje sair.

using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            float x = 0;
            float y = 0;
            bool encerrar = false;

            while (!encerrar)
            {
                Console.WriteLine("1 Somar");
                Console.WriteLine("2 Subtrair");
                Console.WriteLine("3 Multiplicar");
                Console.WriteLine("4 Dividir");
                Console.WriteLine("0 Sair");
                Console.Write("Escolha: ");
                int opcao = Convert.ToInt32(Console.ReadLine());


                if (opcao > 0 && opcao < 5)
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    x = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    y = float.Parse(Console.ReadLine());
                }
                else if (opcao == 0) 
                {
                    encerrar = true;
                }



                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (x + y));
                        break;

                    case 2:
                        Console.WriteLine("Resultado: " + (x - y));
                        break;

                    case 3:
                        Console.WriteLine("Resultado: " + (x * y));
                        break;

                    case 4:
                        if (y == 0)
                        {
                            Console.WriteLine("Divisão por zero");
                            break;
                        }
                        Console.WriteLine("Resultado: " + (x / y));
                        break;

                    default:
                        Console.WriteLine("Saindo do App");
                        break;
                }
                Console.WriteLine();
            }
                
        }
    }
}