using System;

namespace IS1_GrupoX_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MostrarBanner();
            MostrarAporteEstudiante2();

            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void MostrarBanner()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine(" IS1 - Grupo5 - Laboratorio 1");
            Console.WriteLine(" Origen del Software y Control de Versiones");
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }

    
        static void MostrarAporteEstudiante2()
        {
            Console.WriteLine("Tema: Manifiesto Ágil");
            Console.WriteLine("Estudiante: [Rebecca Aurora Aguirre Batres]");
            Console.WriteLine();

            Console.WriteLine("Contexto:");
            Console.WriteLine("El Manifiesto Ágil, publicado en 2001, sentó las bases para");
            Console.WriteLine("transformar la gestión de proyectos, priorizando la adaptabilidad,");
            Console.WriteLine("las personas y la entrega de valor real.");
            Console.WriteLine();

            Console.WriteLine("--- Los 4 Valores Fundamentales ---");
            Console.WriteLine("1. Individuos e interacciones sobre procesos y herramientas.");
            Console.WriteLine("2. Software funcionando sobre documentación exhaustiva.");
            Console.WriteLine("3. Colaboración con el cliente sobre negociación contractual.");
            Console.WriteLine("4. Respuesta ante el cambio sobre seguir un plan.");
            Console.WriteLine();

            Console.WriteLine("--- Los 12 Principios Ágiles ---");
            Console.WriteLine(" 1. Satisfacción del cliente mediante entrega temprana y continua.");
            Console.WriteLine(" 2. Bienvenida al cambio, incluso en etapas tardías.");
            Console.WriteLine(" 3. Entregas frecuentes de software funcional.");
            Console.WriteLine(" 4. Trabajo en equipo diario entre negocio y desarrolladores.");
            Console.WriteLine(" 5. Individuos motivados, con entorno y apoyo adecuados.");
            Console.WriteLine(" 6. Comunicación cara a cara como método más eficiente.");
            Console.WriteLine(" 7. El software funcionando es la medida de progreso.");
            Console.WriteLine(" 8. Desarrollo sostenible, a ritmo constante.");
            Console.WriteLine(" 9. Atención continua a la excelencia técnica y buen diseño.");
            Console.WriteLine("10. Simplicidad: maximizar el trabajo NO realizado.");
            Console.WriteLine("11. Las mejores soluciones surgen de equipos autoorganizados.");
            Console.WriteLine("12. Reflexión y mejora continua a intervalos regulares.");
            Console.WriteLine();

            Console.WriteLine("--- Caso Real: App de Pagos y Remesas en El Salvador ---");
            Console.WriteLine("Contexto: una institucion financiera en San Salvador lanza una app");
            Console.WriteLine("de pagos. Con el modelo tradicional (8-12 meses de entrega), la app");
            Console.WriteLine("llegaba desactualizada frente a los cambios normativos del BCR.");
            Console.WriteLine();
            Console.WriteLine("Con enfoque Agil:");
            Console.WriteLine("- Se integro a oficiales de cumplimiento con los programadores (Scrum).");
            Console.WriteLine("- Despliegues quincenales probados por usuarios reales.");
            Console.WriteLine("- Renegociacion inmediata del alcance en cada sprint.");
            Console.WriteLine("- Equipos autoorganizados con autonomia sobre arquitectura (AWS/Azure).");
            Console.WriteLine("- Pruebas automatizadas para transacciones monetarias reales.");
            Console.WriteLine("- Ritmo sostenible y retroalimentacion quincenal del equipo.");
        }
    }
}
