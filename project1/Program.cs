//codigo de prueba
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);
/// /// /// /// ///
Console.WriteLine("Ejercicio 1");
Console.WriteLine("Ingrese un numero distinto de cero");
float Fnumero;
string dato = Console.ReadLine();
if (float.TryParse(dato,out Fnumero) && Fnumero != 0)
{
    Fnumero = 1 / Fnumero;

    Console.WriteLine($"El numero es: {Fnumero}");
}
else
{
    Console.WriteLine("El numero debe ser distinto de 0");
}

//ejercicio 2 (al ejercicio 5 hacerlo en un proyecto separado)
int opcion=0;
do {
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Terminar programa");

    string opcionIngresada = Console.ReadLine();
    if (int.TryParse(opcionIngresada, out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese los dos numeros a sumar");
                Calculadora.MostrarResultado(Calculadora.Suma(Calculadora.PedirNumero(), Calculadora.PedirNumero()));
                break;
            case 2:
                Console.WriteLine("Ingrese los dos numeros a restar");
                Calculadora.MostrarResultado(Calculadora.Resta(Calculadora.PedirNumero(), Calculadora.PedirNumero()));
                break;
            case 3:
                Console.WriteLine("Ingrese los dos numeros a multiplicar");
                Calculadora.MostrarResultado(Calculadora.Multiplicacion(Calculadora.PedirNumero(), Calculadora.PedirNumero()));
                break;
            case 4:
                Console.WriteLine("Ingrese los dos numeros a dividir");
                float dividendo = Calculadora.PedirNumero();
                float divisor;
                do {
                    divisor = Calculadora.PedirNumero();
                    if (!(divisor == 0))
                    {
                        Calculadora.MostrarResultado(Calculadora.Division(dividendo, divisor));
                    }
                    else
                    {
                        Console.WriteLine("El divisor debe ser distinto de 0, ingrese el numero nuevamente");
                    }
                } while (divisor == 0);
                break;
            case 5:
                Console.WriteLine("adios");
                break;
            default:
                Console.WriteLine("Ingrese una opcion del 1 al 5");
                break;
        }
    }
}while(opcion == 0);
