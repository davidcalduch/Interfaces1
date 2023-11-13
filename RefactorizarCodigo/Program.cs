using System;

namespace RefactorizarCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la pizzeria");
            double precio = CalcularPrecioPizza();
            Console.WriteLine($"El precio de la pizza es {precio}");
        }
        public static double CalcularPrecioPizza()
        {
            Console.WriteLine("¿Cuántos ingredientes quieres?");
            Console.WriteLine("1. Queso");
            Console.WriteLine("2. Jamón");
            Console.WriteLine("3. Champiñones");
            Console.WriteLine("4. Piña");
            Console.WriteLine("5. Salami");
            Console.WriteLine("6. Aceituna ");
            Console.WriteLine("7. Todos");
            double precio = 0;
            int opcion = 0;
            try
            {
                 opcion = int.Parse(Console.ReadLine());
                
            }catch(Exception e)
            {
                Console.WriteLine("Opción no válida");
                Environment.Exit(1);
            }
            switch (opcion)
            {
                case 1: 
                        precio = 5;
                    break;
                case 2: 
                        precio = 6;
                    break;
                case 3:
                    precio = 7;
                    break;
                case 4:
                    precio = 8;
                    break;
                case 5:
                    precio = 9;
                break;
                case 6:
                    precio = 10;
                break;
                 case 7:
                    precio = 11;
                 break;
                    default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.WriteLine("Que tamaño quieres?");
            Console.WriteLine("1. Pequeña");
            Console.WriteLine("2. Mediana");
            Console.WriteLine("3. Grande");
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Opción no válida");
            }
            switch (opcion)
            {
                case 1:
                    precio *= 0.8;
                    break;
                case 2:
                    precio *= 1;
                    break;
                case 3:
                    precio *= 1.2;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
            Console.WriteLine("¿Quieres que te la entreguen a domicilio?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Opción no válida");
            }
            switch (opcion)
            {
                case 1:
                    precio += 2;
                    break;
                case 2:
                    precio += 0;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    Environment.Exit(1);
                    break;
            }
            return precio;
        }
    }
}

   