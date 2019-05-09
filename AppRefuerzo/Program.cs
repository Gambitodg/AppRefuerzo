using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRefuerzo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            bool estado = false;
            var edad =0;
            var resultado = 0.0;

            Console.Write("Digite la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Bienvenido \n Su nombre es:{nombre} \n su edad es: {edad}");
            Console.WriteLine("Bienvenio Su nombre es:" + nombre + "Sue edad es:" + edad);
            Console.WriteLine("Bienvenido su nombre es:{0} y su edad es {1}",nombre,edad);

            if (estado==false)
            {
                edad+=50;
            }
            else
            {
              resultado = Math.Sqrt(edad);

                Console.Write($"La raiz cuadrada de edad:{resultado}");
            }
            

            Console.ReadLine();
        }
    }
    
}
