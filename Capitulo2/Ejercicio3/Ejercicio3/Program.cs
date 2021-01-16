using System;


namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float grado, radian;
            Console.WriteLine("Programa que transforma de grados a radianes: ");
            
            Console.Write("Digite los grados: ");
            grado = float.Parse(Console.ReadLine());

            radian = (grado * 3.1416f) / 180;
            Console.Write("Radian: {0}", radian);
        }
    }
}
