static double SolicitarNumero()
{
    Console.WriteLine("Dame un numero.");
    Console.Write(">> ");
    string numero = Console.ReadLine()!;
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
    string entrada = Console.ReadLine()!;
    switch (entrada)
    {
        case "+":
            Console.WriteLine("Suma.");
            return entrada;
            
        case "-":
            Console.WriteLine("Resta.");
            return entrada;
            
        case "*":
            Console.WriteLine("Multiplicacion.");
            return entrada;
            
        case "/":
            Console.WriteLine("Division.");
            return entrada;
            
        default:
            Console.WriteLine("Operacion no permitida.");
            return SolicitarOperacion(); 
            
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
    double resultado = 0;
    switch (op)
    {
        case "+":
        resultado = a + b;
        break;
        case "-":
        resultado = a - b;
        break;
        case "*":
        resultado = a * b;
        break;
        case "/":
        if (b==0) return "Error: Division por cero.";
        resultado = a / b;
        break;
        default:
        return "Operacion invalida.";
    }
    return $"Resultado: {resultado}";
}

Console.WriteLine(Calcular(a,b,op));
