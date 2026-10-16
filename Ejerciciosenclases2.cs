using System;
using System.ComponentModel.Design.Serialization;
using System.IO;

namespace Clase_1
{
    internal static class Program
    {

        static void Main()
        {
            string ruta = "D:\\estudiantes.csv";
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}, Sexo: {campos[4]}");
                }
                using (StreamWriter sw = new StreamWriter("D:\\estudiantes.csv", append: true))
                {
                    sw.WriteLine("Pedro,23,1.3,Loduda");
                    sw.WriteLine("Anuar,20,4.5,Masculino");
                    sw.WriteLine("pepito,44,4.9,Masculino");
                    sw.WriteLine("rosa,55,2.5,Mujer");
                }
            }
            

            
            
        }
    }
}
