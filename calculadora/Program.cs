﻿using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarar valiables
            //tipo de dato: int, float, char, bool
            int n1, n2, resultado;

            // pedir valores
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            // realizar calculo
            resultado = n1 + n2;
            //emitir resultado.
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
