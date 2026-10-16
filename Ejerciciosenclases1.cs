using System;
using System.IO;

namespace Clase_1
{
    internal static class Program
    {

        static void Main()
        {
            string ruta = "D:\\estudiantes.csv";


            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre,Edad,Nota,Materia,sexo,Ciudad");
                sw.WriteLine("Maria,20,85,Estructura,Femenino,Barranquilla");
                sw.WriteLine("Carlos,22,90,Estructura,Masculino,Cienaga");
                sw.WriteLine("Martina,21,78,Estructura,Femenino,SantaMarta");
                sw.WriteLine("Anuar,20,Estructura,Masculino,Sincelejo");
            }

            Console.WriteLine("Archivo creado exitosamente.");
        }
    }
}
