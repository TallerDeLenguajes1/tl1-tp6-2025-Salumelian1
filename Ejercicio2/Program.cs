int num;
Console.WriteLine("Ingresar el numero que quiere invertir: ");
num = Convert.ToInt32(Console.ReadLine());
if (num < 10)
{
    Console.WriteLine("El numero invertido es: " + num);
}
else
{
    while (num >= 1)
    {
        int digito = num % 10;
        num = num / 10;
        Console.WriteLine(digito);
    }
}