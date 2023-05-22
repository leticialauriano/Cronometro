using System;
using System.Threading;


namespace Cronometro
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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();
            char tipo = char.Parse(dados.Substring(dados.Length - 1, 1)); //Substring: posição e quantos caracteres
            int tempo = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplicador = 1;


            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            PreInicio(tempo * multiplicador);
        }

        static void PreInicio(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Pronto...");
            Thread.Sleep(1000);
            Console.WriteLine("Tudo certo...");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos...");
            Thread.Sleep(2500);

            Inicio(tempo);
        }


        static void Inicio(int tempo)
        {

            int horaAtual = 0;

            while (horaAtual != tempo)
            {
                Console.Clear();
                horaAtual++;
                Console.WriteLine(horaAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
