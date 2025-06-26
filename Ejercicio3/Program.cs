using System;
int Opcion = 0, num1 = 0, num2 = 0; 
double num = 0;

Console.WriteLine("----------Incio del programa---------");
do
{
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Producto");
    Console.WriteLine("4. Cociente");
    Console.WriteLine("5. Operaciones con un solo número");
    Console.WriteLine("6. Máximo y mínimo entre dos números");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Ingrese la opcion que desea: ");
    Opcion = Convert.ToInt32(Console.ReadLine());
    if (Opcion >= 1 && Opcion <= 4 || Opcion == 6)
    {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
    }
    switch (Opcion)
    {
        case 1:
            Console.WriteLine("La suma de ambos numeros es: " + (num1 + num2));
            break;
        case 2:
            Console.WriteLine("La resta de ambos numeros es: " + (num1 - num2));
            break;
        case 3:
            Console.WriteLine("El producto entre ambos numeros es: " + (num1 * num2));
            break;
        case 4:
            if (num2 != 0)
            {
                Console.WriteLine("La divicion entre ambos numeros es: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
            break;
        case 5:
            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Parte entera: " + Math.Truncate(num));

            break;
        case 6: 
            Console.WriteLine("Máximo: " + Math.Max(num1, num2));
            Console.WriteLine("Mínimo: " + Math.Min(num1, num2));
            break;
    }
} while (Opcion != 0);