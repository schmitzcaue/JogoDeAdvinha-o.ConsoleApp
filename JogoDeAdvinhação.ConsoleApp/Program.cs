namespace JogoDeAdivinhacao.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] numerosChutados = new string[100];
            int contador = 0;

            while (true)
            {
                int totaldetentativas = 0;

                string escolhaDeDificuldade = ExibirMensagem();

                if (escolhaDeDificuldade == "1")
                    totaldetentativas = 10;

                else if (escolhaDeDificuldade == "2")
                    totaldetentativas = 5;

                else
                    totaldetentativas = 3;

                Random geradorDeNumeros = new Random();

                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                for (int tentativa = 1; tentativa <= totaldetentativas; tentativa++)
                {
                    ExibirTentativa(tentativa, totaldetentativas);

                    if (numerodigitado == numeroSecreto)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine("--------------------------------------");
                        break;
                    }
                    else if (tentativa == totaldetentativas)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"Que pena! Você usou todas as tentativas. O número era {numeroSecreto}.");
                        Console.WriteLine("--------------------------------------");
                        break;
                    }
                    else if (numerodigitado > numeroSecreto)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("O número digitado foi maior que o número secreto!");
                        Console.WriteLine("--------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("O número digitado foi menor que o número secreto!");
                        Console.WriteLine("--------------------------------------");
                    }

                    Console.WriteLine("Aperte ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }

            Console.ReadLine();

            static string ExibirMensagem()
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Jogo De Adivinhação");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Escolha um nível de dificuldade: ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1 - facíl (10 tentativas)");
                Console.WriteLine("2 - normal (5 tentativas)");
                Console.WriteLine("3 - difícil (3 tentativas)");
                Console.WriteLine("--------------------------------------");

                Console.Write("Digite sua escolha: ");
                string escolhaDeDificuldade = Console.ReadLine();

                return escolhaDeDificuldade;
            }

            static void ExibirTentativa(int tentativa, int totaldetentativas)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Tentativa {tentativa} de {totaldetentativas}");
                Console.WriteLine("--------------------------------------");

                Console.Write("Digite um número (de 1 à 20) para chutar: ");
                int numerodigitado = Convert.ToInt32(Console.ReadLine());


            }
        }

    }
}
