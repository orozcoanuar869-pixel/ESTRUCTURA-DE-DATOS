using System;

class Program
{
    static void Main()
    {
        // Total de estudiantes modificado a 20
        const int totalEstudiantes = 20; 

        // 1. Declaración de arreglos estáticos paralelos
        string[] nombres = new string[totalEstudiantes];
        double[] calificaciones = new double[totalEstudiantes];

        Console.WriteLine($"=== REGISTRO DE CALIFICACIONES ({totalEstudiantes} ESTUDIANTES) ===");

        // 2 y 3. Solicitud y validación de datos por cada estudiante
        for (int i = 0; i < totalEstudiantes; i++)
        {
            Console.WriteLine($"\n--- Estudiante {i + 1} de {totalEstudiantes} ---");

            // Validación del nombre usando un ciclo for (sin while ni do-while)
            string nombre = "";
            for (bool nombreValido = false; !nombreValido; )
            {
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombreValido = true;
                }
                else
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío ni contener solo espacios.");
                }
            }
            nombres[i] = nombre;

            // Validación de la calificación usando un ciclo for (sin while ni do-while)
            double calificacion = 0;
            for (bool notaValida = false; !notaValida; )
            {
                Console.Write("Ingrese la calificación (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out calificacion) && calificacion >= 0.0 && calificacion <= 5.0)
                {
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: La nota debe ser un número decimal válido entre 0.0 y 5.0.");
                }
            }
            calificaciones[i] = calificacion;
        }

        // 5. Cálculos estadísticos
        double suma = 0;
        double notaMayor = calificaciones[0];
        double notaMenor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < totalEstudiantes; i++)
        {
            double nota = calificaciones[i];
            suma += nota;

            if (nota > notaMayor)
            {
                notaMayor = nota;
            }
            if (nota < notaMenor)
            {
                notaMenor = nota;
            }

            if (nota >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / totalEstudiantes;

        // 5. Reporte final
        Console.WriteLine("\n========================================");
        Console.WriteLine("           REPORTE FINAL DEL GRUPO      ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Promedio del grupo:   {promedio:F2}");
        Console.WriteLine($"Nota mayor del grupo: {notaMayor:F1}");
        Console.WriteLine($"Nota menor del grupo: {notaMenor:F1}");
        Console.WriteLine($"Cantidad aprobados:   {aprobados} (>= 3.0)");
        Console.WriteLine($"Cantidad reprobados:  {reprobados} (< 3.0)");
        Console.WriteLine("========================================");
    }
}
