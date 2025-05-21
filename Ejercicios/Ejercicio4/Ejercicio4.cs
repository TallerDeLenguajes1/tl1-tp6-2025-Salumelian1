string? entrada;
string cadena = "", cadena2 ="";

do
{
    Console.WriteLine("Ingrese una cadena de texto: ");
    entrada = Console.ReadLine();

    if (entrada != null)
    {
        cadena = entrada;
    }

} while (entrada != null);

int longitud = cadena.Length;
Console.WriteLine("Longitud de la última cadena ingresada: " + longitud);

do
{
    Console.WriteLine("Ingrese una cadena de texto: ");
    entrada = Console.ReadLine();

    if (entrada != null)
    {
        cadena2 = entrada;
    }

} while (entrada != null);

string concatenado = cadena + cadena2;
string subcadena2 = cadena2.Substring(0,5);