
Console.WriteLine("Ingrese una frase por pantalla: ");
string frase = Convert.ToString(Console.ReadLine())!;//El ! Hace que el programa confie de que no sera null

Console.WriteLine("La longitud de la frase es: " + frase.Length);
Console.WriteLine("Ingrese una segunda frase por pantalla: ");
string frase2 = Convert.ToString(Console.ReadLine())!;
string Convinado = frase + ' ' +frase2;
Console.WriteLine("Ambas frases convinadas es: " + Convinado);
Console.WriteLine("Una sub cadena de la frase1 es: " + frase.Substring(0, 4));
 Console.WriteLine("Caracteres de la frase 1:");
        foreach (char c in frase)
        {
            Console.WriteLine(c);
        }

        // Búsqueda de palabra
        Console.WriteLine("Ingrese una palabra para buscar en la primera frase:");
        string palabra = Console.ReadLine()!;
        if (frase.Contains(palabra))
            Console.WriteLine("La palabra existe en la frase.");
        else
            Console.WriteLine("La palabra no se encontró en la frase.");

        // Mayúsculas y minúsculas
        Console.WriteLine("Frase en mayúsculas: " + frase.ToUpper());
        Console.WriteLine("Frase en minúsculas: " + frase.ToLower());

        // Separar por palabras
        Console.WriteLine("Palabras de la frase:");
        string[] palabras = frase.Split(' ');
        foreach (string p in palabras)
        {
            Console.WriteLine(p);
        }

        // Evaluar una expresión matemática del tipo "582+2"
        Console.WriteLine("Ingrese una expresión matemática simple (ej: 582+2):");
        string expresion = Console.ReadLine()!;
        EvaluarExpresionSimple(expresion);
    static void EvaluarExpresionSimple(string expresion)
{
    char[] operadores = { '+', '-', '*', '/' };
    foreach (char op in operadores)
    {
        int pos = expresion.IndexOf(op);
        if (pos > 0)
        {
            string izquierda = expresion.Substring(0, pos);
            string derecha = expresion.Substring(pos + 1);

            if (double.TryParse(izquierda, out double num1) && double.TryParse(derecha, out double num2))
            {
                double resultado = 0;
                switch (op)
                {
                    case '+': resultado = num1 + num2; break;
                    case '-': resultado = num1 - num2; break;
                    case '*': resultado = num1 * num2; break;
                    case '/':
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                            return;
                        }
                        break;
                }
                Console.WriteLine($"Resultado de {num1} {op} {num2} = {resultado}");
                return;
            }
            else
            {
                Console.WriteLine("No se pudo interpretar la expresión.");
                return;
            }
        }
    }
    Console.WriteLine("No se encontró un operador válido en la expresión.");
}