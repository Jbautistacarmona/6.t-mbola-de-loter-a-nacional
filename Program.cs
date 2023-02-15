using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.tómbola_de_lotería_nacional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la tómbola de lotería!");//mensaje de benvenida al usuario.
            Console.WriteLine("Presione Enter para seleccionar los números ganadores...");
            Console.ReadLine();

            Random rnd = new Random(); //random generador
            int firstPlace = rnd.Next(1, 100);//para el primer numero
            int secondPlace = rnd.Next(1, 100);//segundo numero generado
            int thirdPlace = rnd.Next(1, 100);//ultimo nuevo generado,

            Console.WriteLine("Los números ganadores son: ");
            Console.WriteLine("1er lugar: " + firstPlace);
            Console.WriteLine("2do lugar: " + secondPlace);
            Console.WriteLine("3er lugar: " + thirdPlace);
            Console.ReadLine();//imprimir resultado en pantalla
        }
    }
}