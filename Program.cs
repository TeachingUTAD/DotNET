using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribir algo en consola
            Console.WriteLine("Hola mundo");
            Console.ReadKey(true);

            //Pedir datos al usuario y luego escribirlos en consola
            Console.WriteLine("Como te llamas?");
            var nombre = Console.ReadLine();
            Console.WriteLine("Qué edad tienes?");
            var edad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", me gustan tus " + edad + " años.");
            Console.ReadKey(true);

            //Leo la fecha del sistema y la pinto usando $ y retornos de carro independientes de la plataforma
            var fecha = DateTime.Now;
            Console.WriteLine($"Hola {nombre} hoy es: {Environment.NewLine} {fecha:d}");
            Console.ReadKey(true);


        }
    }
}
