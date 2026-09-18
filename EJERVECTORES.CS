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
            String[] estudiante = 
                { "ANA", "LUIS", "CARLOS", "MARTA","ANUAR"};
            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.WriteLine($"índice [{i}]: {estudiante[i]}");
            }
        }
    }
}
