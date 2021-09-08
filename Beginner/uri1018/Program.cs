//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
//As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

//Entrada
//O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

//Saída
//Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.

using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroNotas, resto, nota;
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            nota = 50;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            nota = 20;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            nota = 10;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            nota = 5;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            nota = 2;
            numeroNotas = resto / nota;
            Console.WriteLine($"{numeroNotas} nota(s) de R$ {nota},00");
            resto %= nota;

            Console.WriteLine($"{resto} nota(s) de R$ 1,00");
        }
    }
}
