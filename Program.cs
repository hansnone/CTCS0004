static double SolicitarNumero()
{
    Console.WriteLine("Dame un numero.");
    Console.Write(">> ");
    string numero = Console.ReadLine();
    if (double.TryParse(numero, out double numero2))
    {
        return numero2;
    }
    else
    {
        Console.WriteLine("Entrada invalida. Intente de nuevo.");
        return SolicitarNumero();
    }
}
static string SolicitarOperacion()
{
    Console.WriteLine("Operaciones validas: +, -, * y //.");
    string entrada = Console.ReadLine();
    inicio:
    switch (entrada)
    {
        case "+":
            Console.WriteLine("Suma.");
            return entrada;
            break;
        case "-":
            Console.WriteLine("Resta.");
            return entrada;
            break;
        case "*":
            Console.WriteLine("Multiplicacion.");
            return entrada;
            break;
        case "/":
            Console.WriteLine("Division.");
            return entrada;
            break;
        default:
            Console.WriteLine("Operacion no permitida.");
            return SolicitarOperacion(); 
            break;
    }
}

double a = SolicitarNumero();
double b = SolicitarNumero();
string op = SolicitarOperacion();

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(op);

static string Calcular(double a, double b, string op)
{
    if (op == "*")
    {
        Console.WriteLine(a * b);
    }
}
