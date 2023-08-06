using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Reflection.Metadata.Ecma335;

namespace Exercicios
{
    internal class CondicaoIF
    {
        double numero = 0;
        double numero1 = 0;


        /* o foreach precisa ter um modificador vazio ( void) para poder ser sem retorno, e dentro
         * dos parametros, posso citar variaveis, ou objetos */
        public void ForEach(double numero ,double numero1)
        {
            Console.WriteLine(" o numero é:"+ numero);
        }
        
    }
}
