// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        private static void menu()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("O que deseja fazer: ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtracao ");
            Console.WriteLine("3 - Divisao ");
            Console.WriteLine("4 - Multiplicação ");
            Console.WriteLine("0 - Para sair do programa.");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short numeroEscolhido = short.Parse(Console.ReadLine());

            switch(numeroEscolhido)
            {
                case 1:
                    Console.WriteLine("Voce selecionou a soma!");
                    Soma.soma();
                break;
                
                case 2:
                    Console.WriteLine("Você selecionou subtracao!");
                    Subtracao.subtracao();
                    break;
                
                case 3:
                    Console.WriteLine("Você selecionou Divisao!");
                    Divisao.divisao();
                    break;
                
                case 4:
                    Console.WriteLine("Você selecionou multiplicação!");
                    Multiplicacao.multiplicacao();
                break;
                
                case 0:
                    Environment.Exit(0);
                    Console.WriteLine("Obrigado por utilizar o programa!");
                break;

                default:
                    menu();
                break;
            }
        }

        private static void mensagem(short numeroEscolhido)
        {
            string msg = $"Você digitou {numeroEscolhido}. Apenas os numeros apresentados são validos, tente novamente.";
            Console.WriteLine(msg);
        }
    }
}