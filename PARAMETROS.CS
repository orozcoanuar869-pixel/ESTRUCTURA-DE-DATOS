using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    internal class Program
    {
        //procedimiento sumar e imprimir
        public static void  ImprimirSumar(int a, int b)// a , b son los parametros
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }
        public static void MostrarPotenciaX(double num1, double potencia)
        {
            double result = Math.Pow( num1,  potencia);
            Console.WriteLine($"La potencia de {num1} elevado a {potencia} es: {result}");

        }
        static void ModificarValor(int n)
        {
            n = n + 1;
            Console.WriteLine($"Dentro del Metodo: {n}");
        }

        static void Main(string[] args)
        {
            int x = 12, y = 23;
           

            ImprimirSumar(y, x); //y, x (Argumentos Actuales)
            ImprimirSumar(1000, -1); // (Argumentos Literales)
            MostrarPotenciaX(12, 3);
            int edad = 20;
            Console.WriteLine($"Antes del metodo: {edad}");
            ModificarValor(edad);
            Console.WriteLine($"Despues del Metodo: {edad}");
            
        }
    }
}
