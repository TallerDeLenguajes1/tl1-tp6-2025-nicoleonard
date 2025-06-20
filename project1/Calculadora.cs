//codigo de prueba
public static class Calculadora
{
    public static float PedirNumero()
    {
        float numeroIngresado;
        string entrada;
        bool resultadoParse;
        Console.WriteLine("Ingrese un numero real");
        do
        {
            entrada = Console.ReadLine();
            resultadoParse = float.TryParse(entrada, out numeroIngresado);
        } while (!resultadoParse);
        return numeroIngresado;
    }
    public static void MostrarResultado(float numero)
    {
        Console.Write("Resultado: ");
        Console.WriteLine(numero);
    }
    public static void ValorAbsoluto(float numero)
    {
        MostrarResultado(float.Abs(numero));
    }

    public static void Cuadrado(float numero)
    {
        MostrarResultado(float.Pow(numero, numero));
    }

    public static void RaizCuadrada(float numero)
    {
        MostrarResultado(float.Sqrt(numero));
    }
    public static void Seno(float numero)
    {
        MostrarResultado(float.Sin(numero));
    }
    public static void Coseno(float numero)
    {
        MostrarResultado(float.Cos(numero));
    }
    public static void ParteEntera(float numero)
    {
        MostrarResultado(float.Round(numero, 0));
    }
    public static void Maximo(float numero1, float numero2)
    {
        MostrarResultado(float.Max(numero1, numero2));
    }
    public static void Minimo(float numero1, float numero2)
    {
        MostrarResultado(float.Min(numero1, numero2));
    }
}