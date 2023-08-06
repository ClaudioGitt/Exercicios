using System;

namespace Exercicios
{
    internal class LoopWhile
    {
        public class Classe1
        {
            public static void ExemploLoopWhile()
            {
                bool condicao = true;

                while (condicao)
                {
                    Console.WriteLine("Executando o loop while");
                    // Outras instruções aqui

                    // Definir uma condição de saída para evitar um loop infinito
                    condicao = false;
                }
            }
        }

        public static void Main(string[] args)
        {
            Classe1.ExemploLoopWhile();
        }
    }
}
