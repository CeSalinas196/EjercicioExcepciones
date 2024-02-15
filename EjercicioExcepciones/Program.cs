
using System;

class Program
{
    static void Main()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.\n");
                    continue;
                }

                if (opcion == 5)
                {
                    Console.WriteLine("Saliendo del programa.");
                    break;
                }

                Console.Write("Ingrese el primer número: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Error: Ingrese un formato de número válido.\n");
                    continue;
                }

                Console.Write("Ingrese el segundo número: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Error: Ingrese un formato de número válido.\n");
                    continue;
                }

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = Operaciones.Sumar(num1, num2);
                        break;
                    case 2:
                        resultado = Operaciones.Restar(num1, num2);
                        break;
                    case 3:
                        resultado = Operaciones.Multiplicar(num1, num2);
                        break;
                    case 4:
                        try
                        {
                            resultado = Operaciones.Dividir(num1, num2);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}\n");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.\n");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
