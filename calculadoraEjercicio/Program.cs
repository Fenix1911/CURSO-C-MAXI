using System;

namespace calculadoraEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int resultado;

            Console.WriteLine("Ingrese un numero para elevar al cubo: ");
            n1 = int.Parse(Console.ReadLine());
            resultado = n1 * n1 * n1;
            Console.WriteLine("El numero ingresado elevado al cubo es: " + resultado);
        }
    }
}


