using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Palindromo
    {
        static void Main()
        {
            // Verificação de palindromo, ( a palavra pode ser lida da esquerda para a direita
            // e vice-versa.
            Console.WriteLine("Digite uma palavra: ");
            // primeiro um writeline, que solicita o usuário e depois um readline para ler
            // o que o usuário digita.
            string palavra=Console.ReadLine();
            //Aqui em palavrainvertida, deixei vazio para que o usuário possa inserir o texto e
            // o objeto palavrainvertida possa receber o texto fornecido pelo usuário.
            string palavrainvertida = "";

            // Agora vem a lógica, neste caso o exemplo utiliza um for.
            // Parece que na condição for, a lógica vai dentro do parâmetro. ()
            for (int i = palavra.Length -1;  i >= 0; i--)
            {
                palavrainvertida += palavra[i];
            }

            // outra condição criada, nesse caso um if ( se ).
            // o if cita os objetos palavra e aciona o método Equals, e nos parametros temos
            // o objeto citado em if que é palavrainvertida, e um stromgcp,árospm.OrinalIgnoreCase
            // Que ignora a ordem em que as palavras são escritas.
            if (palavra.Equals(palavrainvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(" A palavra é um palindromo");
            }
            else
            {
                Console.WriteLine(" A palavra não é um palindromo");
            }
            Console.ReadKey();
            
        }
    }
}
