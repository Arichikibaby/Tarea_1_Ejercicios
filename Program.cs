using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Evaluar si un número es positivo, negativo o cero
        Console.WriteLine("Ingrese un número para evaluar si es positivo, negativo o cero:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida, por favor ingrese un número entero.");
        }

        // 2. Evaluar una calificación
        Console.WriteLine("\nIngrese una calificación (0 a 100):");
        if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 0 && calificacion <= 100)
        {
            if (calificacion >= 60)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
        else
        {
            Console.WriteLine("Calificación inválida.");
        }

        // 3. Determinar el rango de un número
        Console.WriteLine("\nIngrese un número para verificar en qué rango se encuentra:");
        if (int.TryParse(Console.ReadLine(), out int numeroRango))
        {
            if (numeroRango < 10)
            {
                Console.WriteLine("Menor que 10");
            }
            else if (numeroRango <= 20)
            {
                Console.WriteLine("Entre 10 y 20");
            }
            else
            {
                Console.WriteLine("Mayor que 20");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }

        // 4. Día de la semana
        Console.WriteLine("\nIngrese un número del 1 al 7 para obtener el día de la semana:");
        if (int.TryParse(Console.ReadLine(), out int diaSemana) && diaSemana >= 1 && diaSemana <= 7)
        {
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Número fuera de rango o entrada inválida.");
        }

        // 5. Calculadora básica con switch
        Console.WriteLine("\nIngrese el primer número:");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Ingrese el segundo número:");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
                char operacion = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (operacion)
                {
                    case '+':
                        Console.WriteLine($"Resultado: {numero1 + numero2}");
                        break;
                    case '-':
                        Console.WriteLine($"Resultado: {numero1 - numero2}");
                        break;
                    case '*':
                        Console.WriteLine($"Resultado: {numero1 * numero2}");
                        break;
                    case '/':
                        if (numero2 != 0)
                        {
                            Console.WriteLine($"Resultado: {numero1 / numero2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operación inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para el primer número.");
        }
    }
}

