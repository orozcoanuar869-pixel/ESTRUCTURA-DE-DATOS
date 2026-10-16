using System;
using System.ComponentModel.Design.Serialization;
using System.IO;

namespace Clase_1
{
    internal static class Program
    {

        static void Main()
        {
            string ruta = "D:\\inventario.csv";


            // 1. Generar el archivo con 4 productos
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,Cantidad");
                sw.WriteLine("1,Lápices,15");
                sw.WriteLine("2,Borradores,5");
                sw.WriteLine("3,Cuadernos,8");
                sw.WriteLine("4,Marcadores,20");
            }

            // 2. Leer y filtrar por cantidad menor a 10
            Console.WriteLine("Productos con stock menor a 10:");
            string[] lineas = File.ReadAllLines(ruta);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                int cantidad = int.Parse(campos[2]);

                if (cantidad < 10)
                {
                    Console.WriteLine($"- {campos[1]} (Stock: {cantidad})");
                }
            }
        }
    }
}
