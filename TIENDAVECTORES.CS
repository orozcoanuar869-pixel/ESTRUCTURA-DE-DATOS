using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una tienda registra las ventas de 10 dias en un array doubele[]
            // y necesitamos calcular;
            //1.Calcular el total vendido
            //2.Calcular el promedio diario
            //3.Encontrar el dia con mayor venta 
            //4.Encontrar el dia con menor venta
            //5.Contar cuantos dias superaron el promedio 

            double[] venta = { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211 };
            double total = 0;
            double mayorVenta= venta[0];
            double menorVenta = venta[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;

            for (int i = 0; i < venta.Length; i++)
            {
                total += venta[i];

                if (venta[i] > mayorVenta)
                {
                    mayorVenta = venta[i];
                    diaMayorVenta = i;

                }
                if (venta[i] < menorVenta)
                {
                    menorVenta = venta[i];
                    diaMenorVenta = i;
                }

            }

            double promedio = total / venta.Length;
            int diasSobrePromedio = 0;

            for (int i = 0; i < venta.Length; i++)
            {
                if (venta[i] > promedio)
                {
                    diasSobrePromedio++;
                }
            }

            Console.WriteLine("============== REPORTE DE VENTAS=================");
            Console.WriteLine();
            Console.WriteLine($"TOTAL VENDIDO: ${total:F3}");
            Console.WriteLine($"PROMEDIO DIARIO: ${promedio:F3}");

            Console.WriteLine($"MAYOR VENTA${mayorVenta:F3} =el dia {diaMayorVenta + 1}");
            Console.WriteLine($"MENOR VENTA${menorVenta:F3} =el dia {diaMenorVenta + 1}");

            Console.WriteLine($"Dias que superaron el promedio de Ventas: ${diasSobrePromedio}");
            Console.WriteLine();

            Console.WriteLine("Ventas por dias");
            for (int i = 0;i < venta.Length; i++)
            {
                Console.WriteLine($"Dia {i + 1}: ${venta[i]:F3}");
            }

        }
    }
}
