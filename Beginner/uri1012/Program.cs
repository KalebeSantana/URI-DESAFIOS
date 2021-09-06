//Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
//Entrada
//O arquivo de entrada contém três valores com um dígito após o ponto decimal.

//Saída
//O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima,
//sempre com mensagem correspondente e um espaço entre os dois pontos e o valor.
//O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

using System;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, aTrianguloR, aCirculo, aTrapezio, aQuadrado, aRetangulo;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            aTrianguloR = (A * C) / 2;
            aCirculo = 3.14159 * Math.Pow(C, 2);
            aTrapezio = ((A + B)/2) * C;
            aQuadrado = B * B;
            aRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + aTrianguloR.ToString("F3"));
            Console.WriteLine("CIRCULO: " + aCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + aQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + aRetangulo.ToString("F3"));
        }
    }
}
