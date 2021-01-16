using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado, numLado, resultado;

            Console.Write("Digite el numero de lados: ");
            numLado = float.Parse(Console.ReadLine());

            Console.Write("Digite la longitud de los lados: ");
            lado = float.Parse(Console.ReadLine());

            resultado = lado * numLado;

            Console.Write("El perimeto es: {0}", resultado);


        }
    }
}
