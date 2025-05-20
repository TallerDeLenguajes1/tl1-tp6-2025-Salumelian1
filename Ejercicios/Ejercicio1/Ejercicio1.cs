//Verificar si el texto ingresado sea un numero y luego invertirlo

Console.WriteLine("Ingrese el numero que quiere invertir");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(X);
while (X > 0)
{
    Console.Write(X % 10);
    X = X / 10;
}