[1:28 p. m., 23/10/2026] Anuar: using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

//Resgistro de incidencias de soporte técnico utilizando arcivos (.txt)
//1.Guardar una lista de incidencias atendidas en un archivo de texto( incidencias.txt)
//2. Leer el archivo 
//3. Generar un reporte que cuenta cuántas incidencias hay por prioridad (Alta,Media,Baja)
//La estructura del archivo es:ID,Nombre,Descripción,Prioridad.

//Ejemplo:'01','Anuar Orozco','Daño del Pc','Alta'
namespace ppp
{
    internal class Program
    {
        //C:\Users\SALA-1\Desktop\Anuar_Orozco
        //Creando ruta para guardar mis incidencias.
        static string pathArchivo = "incidencias.txt";

        static void Gua…
[12:26 p. m., 30/10/2026] Anuar: using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

//Resgistro de incidencias de soporte técnico utilizando arcivos (.txt)
//1.Guardar una lista de incidencias atendidas en un archivo de texto( incidencias.txt)
//2. Leer el archivo 
//3. Generar un reporte que cuenta cuántas incidencias hay por prioridad (Alta,Media,Baja)
//La estructura del archivo es:ID,Nombre,Descripción,Prioridad.

//Ejemplo:'01','Shirly Bravo','Daño del Pc','Alta'
namespace ppp
{
    internal class Program
    {
        //C:\Users\SALA-1\Desktop\shirly
        //Creando ruta para guardar mis incidencias.
        static string pathArchivo = "C:\\Users\\SALA-1\\Desktop\\shirly\\incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {

                        sw.WriteLine(incidencia);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al esrcibir el archivo0:  + {ex.Message}");


            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(pathArchivo))
            {
                Console.WriteLine("El archivo no existe aún.");
                return incidencias;
            }

            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo)) 
                {
                    while ((linea = sr.ReadLine()) != null) 
                    {
                        if(!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(',');
                            incidencias.Add(campos);
                          
                        }
                        

                    }
                }
                                   
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error al leer el archivo: {error.Message}");
            }
            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencia para registar.");
                return;
            }

            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();
            foreach (string[] inc in incidencias) 
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //inc['01','Shirly Bravo','Daño del Pc','Alta']
                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;
                }else

                {
                    conteoPorPrioridad[prioridad] = 1;
                }            
            }

            Console.WriteLine($"\n REPORTE DE INCIDENCIAS");
            Console.WriteLine($"Total Atendidas: {incidencias.Count}");
            Console.WriteLine($"Detalle por prioridad");
            foreach (var inc in conteoPorPrioridad)

                Console.WriteLine($"Prioridad: {inc.Key}: {inc.Value}");
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] { "1", "Shirly Bravo", "No imprime", "Alta" },
                new string[] { "2", "Carlos Marínez", "Olvidó contraseña", "Baja" },
                new string[] { "3", "Ana Guette", "Wifi lento", "Alta" },
                new string[] { "4", "Juan Diaz", "Pantalla azul", "Media" },
                new string[] { "5", "María Gomez", "Pc no enciende", "Alta" }
            };

            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");
            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n ---Leyendo incidencias del archivo---");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEÍDAS:");
            Console.WriteLine($"{"ID",-4}  {"Usuario",-15}{"Descripción",-20} {"Prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15}{inc[2],-20}{inc[3],-10}");
            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\n Presione cualquier tecla para salir!!!!");
            Console.ReadKey();
        }
    }
}
