using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class MyRandom
    {
        /* Este código está usando uma classe "Random"
         * que precisa ser inserida dentro de um objeto para que possa
         * ter o comportamento de um objeto no código.
         * Após esta etapa, criei um objeto int chamado randomNumber, que utiliza
         * o método random.Next, que faz com que o compilador leia os números definidos.
         * no caso de 1 a 60, e exibe na tela os valores.
         * 
         * Foi criado um loop while que enquanto a condição for verdadeira, no caso o 
         * Console.WriteLine que pergunta se o usuário quer sair do programa.
         * e se ele quiser sair, se o usuário selecionar que não, o programa volta para o início
         * do looop, gera um novo número e depois retorna ao fim do bloco de código com a pergunta
         * do loop.
         * esse Random foi interessante aprender como ele funciona.
         * PS: observar que posso usar este Random em outras ocasiões.
         */

        static void Main(string[] args)
        {
           
            Random random = new Random();
            while (true)
            {
                int randomNumber = random.Next(1,60);
                Console.WriteLine(" numero foi\n" + randomNumber);
                Console.ReadKey();
                Console.WriteLine(" Deseja sair do programa? 1-Sim\n 2-Não ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 1)
                {
                    Console.WriteLine(" saindo...");
                    break;
                }
                else if (numero == 2)
                {
                    Console.WriteLine(" Voltando...");
                }
            }

            /* Aqui houve um erro bem importante : O compilador dizia que random nao contém uma
             * definição para next. A solução oferecida foi que eu renomeasse a classe Random
             * para que não entrasse em conflito com o system do .NET FRAMEWORK.
             * mas remover a classe random é mais recomendável, a nao ser que eu realmente precise
             * criar a classe igual foi feito. Mas o Random, já está implementado.
             */

        }
    }
}
