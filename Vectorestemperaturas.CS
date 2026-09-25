using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; // Declarando e iniciando

            //Lectura/Escritura de nuestro vector
            Console.WriteLine("====Ingreso de Temperaturas");

            for (int i = 0; i < temperaturas.Length; i++) {
                Console.Write($"Ingrese la temperatura del dia {i + 1}:");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());  
            }
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double temp in temperaturas) 
            {
                suma += temp;
                if (temp > maxT) maxT = temp;
                if (temp < minT) minT = temp;
                               
            }

            double promedio = suma / temperaturas.Length;

            //salida de informacion
            Console.WriteLine("\n---Reporte----");
            Console.WriteLine($"temperaturas registradas:{string.Join(", ", temperaturas)}");
            Console.WriteLine($"Temperatura Promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura Maxima: {maxT}°C");
            Console.WriteLine($"Temperatura Minima: {minT}°C");

        }
        
    }
}
