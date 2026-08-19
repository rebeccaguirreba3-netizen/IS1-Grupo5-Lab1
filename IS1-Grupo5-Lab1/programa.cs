namespace Laboratorio1_IngenieriaSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            // Permite mostrar caracteres especiales, tildes y símbolos en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ENCABEZADO CON TU NOMBRE
            Console.WriteLine("================================================================================");
            Console.WriteLine("                        ESTUDIANTE: KIMBERLY");
            Console.WriteLine("                        GRUPO: GRUPO 5");
            Console.WriteLine("================================================================================");
            Console.WriteLine();

            Console.WriteLine("# Laboratorio 1 - Ingeniería de Software 1");
            Console.WriteLine();

            // 1. HISTORIA
            Console.WriteLine("--- 1. HISTORIA DE LA INGENIERÍA DE SOFTWARE ---");
            Console.WriteLine();
            Console.WriteLine("¿Por qué nació?");
            Console.WriteLine("En los años 60, las computadoras mejoraron muy rápido, pero los programadores no daban abasto.");
            Console.WriteLine("Los programas salían con muchos errores, se tardaban demasiado y salían muy caros (Crisis del Software).");
            Console.WriteLine("Por eso, en 1968 se creó la Ingeniería de Software, para programar con orden y reglas claras.");
            Console.WriteLine();

            Console.WriteLine("¿Cómo evolucionó?");
            Console.WriteLine("* Modelo Tradicional (Cascada): Nació en los años 70. Todo se hace por pasos estrictos: primero planear, luego diseñar, luego programar y al final probar.");
            Console.WriteLine("* Modelos Ágiles: Nacieron en 2001 para solucionar la rigidez del modelo tradicional. Su idea es entregar partes del sistema funcionando rápido y adaptar el proyecto.");
            Console.WriteLine();

            // 2. COMPARACIÓN (TABLA)
            Console.WriteLine("--- 2. COMPARACIÓN: TRADICIONAL VS. ÁGIL ---");
            Console.WriteLine("+------------------+----------------------------------+----------------------------------+");
            Console.WriteLine("| Aspecto          | Desarrollo Tradicional           | Desarrollo Ágil                  |");
            Console.WriteLine("+------------------+----------------------------------+----------------------------------+");
            Console.WriteLine("| Planificación    | Se planifica todo desde el día 1 | Se planifica cada 2 o 3 semanas  |");
            Console.WriteLine("| Entrega          | Se entrega el sistema al final   | Partes funcionales cada semanas  |");
            Console.WriteLine("| El Cliente       | Habla al inicio y al final       | Trabaja de la mano todo el tiempo|");
            Console.WriteLine("| Cambios          | Son un problema y cuestan más    | Son bienvenidos para mejorar     |");
            Console.WriteLine("| Errores          | Se descubren al final            | Se descubren y arreglan rápido   |");
            Console.WriteLine("+------------------+----------------------------------+----------------------------------+");
            Console.WriteLine();

            // 3. PUNTOS CLAVE
            Console.WriteLine("--- 3. PUNTOS CLAVE DEL DESARROLLO ÁGIL ---");
            Console.WriteLine("1. Cliente feliz: Entregar partes del sistema rápido para que el usuario las aproveche pronto.");
            Console.WriteLine("2. Sin miedo a los cambios: Si el cliente pide un cambio, se adapta el plan.");
            Console.WriteLine("3. Programas que funcionen: Vale más entregar software útil que hacer demasiados papeles.");
            Console.WriteLine("4. Trabajo en equipo: Desarrolladores y clientes deben hablar seguido para no perder el rumbo.");
            Console.WriteLine();

            // 4. ESTRUCTURA DEL PROYECTO
            Console.WriteLine("--- 4. ESTRUCTURA DEL PROYECTO ---");
            Console.WriteLine("Nombre del Proyecto: Sistema de Gestión Colaborativa");
            Console.WriteLine("Estructura de Carpetas:");
            Console.WriteLine("  ├── src/           # Código del programa");
            Console.WriteLine("  ├── docs/          # Documentos e información");
            Console.WriteLine("  └── README.md      # Presentación del proyecto");
            Console.WriteLine();

            Console.WriteLine("================================================================================");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
