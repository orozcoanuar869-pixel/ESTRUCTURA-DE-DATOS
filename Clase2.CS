using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7{

    
    internal class Program
    {
        static void ImprimirCabecera(string nombreMateria, int grupo, string nombre , int edad , string carrera , string transporte , string sexo , string estadocivil)
        {
            Console.WriteLine("=============================");
            Console.WriteLine(" UNIVERSIDAD DEL CARIBE");
            Console.WriteLine($"ASIGNATURA: {nombreMateria}");
            Console.WriteLine($" GRUPO: {grupo}");
            Console.WriteLine($" NOMBRE: {nombre}");
            Console.WriteLine($" EDAD: {edad}");
            Console.WriteLine($" CARRERA: {carrera}");
            Console.WriteLine($" TRANSPORTE: {transporte}");
            Console.WriteLine($" SEXO: {sexo}");
            Console.WriteLine($" ESTADO_CIVIL: {estadocivil}");
            Console.WriteLine("=============================");


        }
        static void Main(string[] args) {
            //llamar a la procedimiento ImprimirCabecera
            ImprimirCabecera("Fundamentos de programacion", 1, "ANUAR OROZCO CANTILLO" , 20, "tecnico en informatica" , "MOTO" , "MASCULINO" , "SOLTERO");

        }
    }
}

        }
    }
}
