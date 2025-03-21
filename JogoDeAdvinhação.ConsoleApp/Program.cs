namespace JogoDeAdvinhação.ConsoleApp
{
    internal class Program
    {
        // Versão 3: Verificar se o jogador acertou
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Jogo de adivinhação");
            Console.WriteLine("-------------------------------------------");


            //Lógica do jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);




            Console.Write("Digite um número de 1 à 20 para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Voce acertou!");
                Console.WriteLine("-------------------------------------------");
            }

            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("O numero digitado foi maior que o numero secreto!");
                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("O numero digitado foi menor que o numero secreto!");
                Console.WriteLine("-------------------------------------------");
            }

                Console.ReadLine();
        }
    }
}
