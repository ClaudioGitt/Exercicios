using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{

        //O foco principal do polimorfismo é a capacidade de tratar 
        //objetos de diferentes classes de forma uniforme, chamando 
        //métodos ou acessando propriedades específicas dessas classes.

    public abstract class SerVivo
    {
        public abstract void Respirar();
    }

    public class SerHumano : SerVivo
    {
        public override void Respirar()
        {
            Console.WriteLine("O ser humano está respirando.");
        }
    }

    public class Cachorro : SerVivo
    {
        public override void Respirar()
        {
            Console.WriteLine("O cachorro está respirando.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SerVivo[] seresVivos = new SerVivo[] { new SerHumano(), new Cachorro() };

            foreach (SerVivo ser in seresVivos)
            {
                ser.Respirar();
            }
        }
    }

}
