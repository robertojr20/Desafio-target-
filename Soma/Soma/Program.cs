/*
 1) Observe o trecho de código abaixo:

 int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);

 Ao final do processamento, qual será o valor da variável SOMA?
 Resposta : o valor da soma vai dar "91"
 */


using System;

namespace soma // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int indice = 13, SOMA = 0, K = 0;

            while (K < indice)
            {
                K = K + 1;

                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);
        }
    }
}
