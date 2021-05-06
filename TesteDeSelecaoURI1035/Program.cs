using System;

namespace TesteDeSelecaoURI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            //Vetor declarado, e .Split para capturar e armazenar o valores
            //digitados, separados por espaço, conforme o .Split(' ');
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            //Condição para os VALORES ACEITOS.
            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }

            //Caso contrário, os valores não serão aceitos.
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}
