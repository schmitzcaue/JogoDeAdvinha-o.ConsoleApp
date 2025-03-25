using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDeAdvinhação.ConsoleApp
{
    internal class Program
    {
        // Armazenar e exibir números já digitados
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Jogo de adivinhação");
            Console.WriteLine("-------------------------------------------");


            //Lógica do jogo
            Random geradorDeNumeros = new Random();
            //variavel 
            int[] memoria = new int[20];
            int contador = 0;
            int numeroSecreto = geradorDeNumeros.Next(1, 21);
            int numeroDigitado = 0;
            int pontuacao = 1000;
            while (numeroSecreto != numeroDigitado)
            {


                Console.Write("Digite um número de 1 à 20 para chutar: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                //verifica se tem o numero digitado
                if (memoria.Contains(numeroDigitado))
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Voce já usou essa tentativa!");
                    Console.WriteLine("-------------------------------------------");
                }
                else
                {


                    memoria[contador] = numeroDigitado;
                    // variavel = numeroDigitado

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Voce acertou!");
                        Console.WriteLine("-------------------------------------------");
                        Console.ReadLine();
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("O numero digitado foi maior que o numero secreto!");
                        Console.WriteLine("-------------------------------------------");
                        if (((numeroDigitado - numeroSecreto) / 2) > 0)
                        {
                            pontuacao = pontuacao - ((numeroDigitado - numeroSecreto) / 2);
                        }
                        else
                        {
                            pontuacao = pontuacao - (((numeroDigitado - numeroSecreto) / 2) * -1);
                        }
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("O numero digitado foi menor que o numero secreto!");
                        Console.WriteLine("-------------------------------------------");
                        if (((numeroDigitado - numeroSecreto) / 2) > 0)
                        {
                            pontuacao = pontuacao - ((numeroDigitado - numeroSecreto) / 2);
                        }
                        else
                        {
                            pontuacao = pontuacao - (((numeroDigitado - numeroSecreto) / 2) * -1);
                        }
                    }
                    //aumenta 1 no contador
                    contador++;
                    //ler a linha escolhida
                    // Console.ReadLine();
                }
            }
            Console.Clear();
            for (int i = 0; i < memoria.Length; i++)
            {
                if (memoria [i] > 0)
                Console.WriteLine("tentativa: " + (i + 1) +" - " + memoria[i]);
            }
            Console.WriteLine(pontuacao);
            Console.ReadLine();

        }
    }
}
