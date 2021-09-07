//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

//Entrada
//O arquivo de entrada contém três valores inteiros.

//Saída
//Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, maior;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maior} eh o maior");

        }
    }
}
