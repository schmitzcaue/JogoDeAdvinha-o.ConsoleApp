﻿namespace JogoDeAdvinhação.ConsoleApp
{
    internal class Program
    {
        //  Versão 1: Estrutura básica e entrada do usuário
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Jogo de adivinhação");
            Console.WriteLine("-------------------------------------------");


            //Lógica do jogo
            Console.Write("Digite um número para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você digitou o número: " + numeroDigitado);


            Console.ReadLine();
        }
    }
}
