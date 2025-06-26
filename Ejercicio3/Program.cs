int Opcion = 0, num1 = 0, num2 = 0;

Console.WriteLine("----------Incio del programa---------");
do
{
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Producto");
    Console.WriteLine("4. Cociente");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Ingrese la opcion que desea: ");
    Opcion = Convert.ToInt32(Console.ReadLine());
    if (Opcion != 0)
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
    }
} while (Opcion != 0);