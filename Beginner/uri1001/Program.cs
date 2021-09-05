//Leia 2 variáveis, denominadas A e B e fazer a soma dessas duas variáveis, atribuindo o resultado à variável X .
//Imprima X conforme mostrado abaixo. Imprima a linha final após o resultado, caso contrário, você obterá “ Erro de apresentação ”.

//Entrada
//O arquivo de entrada conterá 2 números inteiros.

//Saída
//Imprime a letra X (maiúscula) com um espaço em branco antes e depois do sinal de igual seguido do valor de X, conforme exemplo a seguir.

using System;

namespace uri1001
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int X = A + B;

            Console.WriteLine("X = {0}", X);

        }

    }
}
