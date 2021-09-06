﻿//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

//Entrada
//O arquivo de entrada contém 2 valores com uma casa decimal cada um.

//Saída
//Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, 
//com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double)

using System;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, media;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            media = ((A * 3.5) + (B * 7.5)) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}
