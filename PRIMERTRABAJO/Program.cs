using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMERTRABAJO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hola, ¿cual es tu nombre?: ");
            string nombre = Console.ReadLine();

            Console.Write("¿Cual es tu edad?: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("¿Cual es tu estatura?: ");
            decimal estatura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"mi nombre es {nombre}, mi edad es {edad} y mi estatura es {estatura:N2} ");
        }
    }
}
