using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            // Mostrar el menú de opciones
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Realizar una operación matemática");
            Console.WriteLine("2. Mostrar un mensaje");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción (1-3): ");

            // Leer la opción del usuario
            opcion = Convert.ToInt32(Console.ReadLine());

            // Procesar la opción seleccionada
            switch (opcion)
            {
                case 1:
                    RealizarOperacionMatematica();
                    break;
                case 2:
                    MostrarMensaje();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción entre 1 y 3.");
                    break;
            }

            Console.WriteLine(); // Línea en blanco para mejorar la legibilidad

        } while (opcion != 3); // Continuar hasta que el usuario elija salir
    }

    static void RealizarOperacionMatematica()
    {
        Console.WriteLine("Operaciones Matemáticas:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Seleccione una operación (1-4): ");

        int operacion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado;

        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    static void MostrarMensaje()
    {
        Console.WriteLine("¡Hola! Este es un mensaje de ejemplo.");
    }
}