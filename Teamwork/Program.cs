using System;

namespace Teamwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.WriteLine("Escriba un numero: "); //*Solicitando datos al usuario*//
            x = Convert.ToInt32(Console.ReadLine()); //*Reconociendo el dato numero 1*//

            Console.WriteLine("Escriba un numero: "); //*Solicitando el segundo dato para poder operarlo*//
            y = Convert.ToInt32(Console.ReadLine()); //*Reconociendo el dato numero 2*//

            Console.WriteLine($"Restando los valores de {x} - {y}"); //*Reaalizando el procedimiento*//
            Console.WriteLine($"El resultado de la resta es:  {subtraction(x,y)}"); //*Mostrar el resultado que obtuvimos*//


        }

        public static int subtraction(int x, int y) //*Funcion para poder operar los datos obtenidos del usuario*//
        {
            return x - y; //*Retorna el valor de la operacion*//
        }

    }

}
