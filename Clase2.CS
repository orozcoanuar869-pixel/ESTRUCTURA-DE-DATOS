using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7{

    
    internal class Program
    {
        static void ImprimirCabecera(string nombreMateria, int grupo, string nombre)
        {
            Console.WriteLine("=============================");
            Console.WriteLine(" UNIVERSIDAD DEL CARIBE");
            Console.WriteLine($"ASIGNATURA: {nombreMateria}");
            Console.WriteLine($" GRUPO: {grupo}");
            Console.WriteLine($" Nombre: {nombre}");
            Console.WriteLine("=============================");


        }
        static void Main(string[] args) {
            //llamar a la procedimiento ImprimirCabecera
            ImprimirCabecera("Fundamentos de programacion", 1, "ANUAR OROZCO CANTILLO");

        }
    }
}
