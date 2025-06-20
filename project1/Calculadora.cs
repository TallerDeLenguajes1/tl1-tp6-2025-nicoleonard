//codigo de prueba
/// /// /// /// ///
//Ejercicio 1

//ejercicio 2 (al ejercicio 5 hacerlo en un proyecto separado)

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

    public static float pedirNumero()
    {

        float.TryParse(Console.ReadLine(), out float numero);
        return numero;
    }
}