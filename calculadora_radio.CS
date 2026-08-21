using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Program
    {

        static double calcularAreacirculo(double radio)
        {
            const double PI = 3.141592;
            //ahora voy a realizar el calculo con la forma
            double area = PI * Math.Pow(radio, 2);
            return area;
        }  
            static void Main(string[] args)
            {
                Console.Write("INGRESE EL RADIO DEL CIRCULO");
                double R = Convert.ToDouble(Console.ReadLine());

                double result = calcularAreacirculo(R);
                Console.WriteLine($"El area es :{result:F2}");

            }
            
          
    }
}
