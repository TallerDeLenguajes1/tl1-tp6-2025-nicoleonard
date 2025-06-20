public static class Calculadora
{
    public static float Suma(float a, float b)
    {
        return a + b;
    }
    public static float Resta(float a, float b)
    {
        return a - b;
    }
    public static float Multiplicacion(float a, float b)
    {
        return a * b;
    }
    public static float Division(float a, float b)
    {
        return a / b;
    }

    public static float PedirNumero()
    {
        bool resultadoParse;
        float numero;
        string dato;
        do
        {
            dato = Console.ReadLine();
            resultadoParse = float.TryParse(dato, out numero);

        } while (!resultadoParse);
        return numero;
    }
    public static void MostrarResultado(float resultado)
    {
        Console.WriteLine($"El resultado de la operacion es : {resultado}");
    }
}