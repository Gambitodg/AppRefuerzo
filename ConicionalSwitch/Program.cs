using System;

namespace ConicionalSwitch
{
    class Program
    {
        //Elaborar un programa que me permita seleccionar operaciones a realizar
        //Opción 1. Raiz
        //Opción 2. Potenciación
        //Opción 3. Valor Absoluto
        //Opcion 4. Cuadrado
        //Opción 5. Salir        
        // Si la opción no se encuentra dentro de estas generar mensaje de error
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Opción 1. Raiz \n Opción 2. Potenciación \n Opción 3. Valor Absoluto \n Opcion 4. Cuadrado \n Opción 5. Salir");
            
            Console.WriteLine("Ingrese la opción:");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Digite número:");
                    var numero = int.Parse(Console.ReadLine());
                    var resraiz = Math.Sqrt(numero);
                    Console.WriteLine($"La raiz del {numero} es : {resraiz}");
                break;
                    
                case 2:
                    Console.WriteLine(" Digite la base:" );
                    var bas = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Digite el exponente:");
                    var exponente = int.Parse(Console.ReadLine());
                    var respotencia = Math.Pow(bas,exponente);
                    Console.WriteLine($"La potencia es: {respotencia}");
                    break;

                case 3:
                    Console.WriteLine("Digite número:");
                    var numeroabs = int.Parse(Console.ReadLine());
                    var resabsoluto = Math.Abs(numeroabs);
                    Console.WriteLine($"El valor absoluto es: {resabsoluto}");
                    break;

                case 4:
                    Console.WriteLine("Digite número:");
                    var numerocua = int.Parse(Console.ReadLine());
                    var rescua = numerocua *= numerocua;
                    Console.WriteLine($"El cuadrado {numerocua} es : {rescua}");
                    break;

                case 5:
                    Console.ReadLine();
                break;

                default:
                    Console.WriteLine("No has seleccionado ninguna opción");
                break;
            }
        }

    }
}
