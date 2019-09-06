using System;
using PersonasClases;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona();
            unaPersona.Password = "";
            Console.WriteLine("El password es: " + unaPersona.Password);
            Console.ReadLine();
        }
    }
}
