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

//ejercicio 3
int opcion=0;
do
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("5. Valor Absoluto");
    Console.WriteLine("6. Cuadrado");
    Console.WriteLine("7. Raiz Cuadrada");
    Console.WriteLine("8. Seno");
    Console.WriteLine("9. Coseno");
    Console.WriteLine("10. Parte Entera");
    Console.WriteLine("11. Maximo");
    Console.WriteLine("12. Minimo");
    Console.WriteLine("0. Terminar programa");

    string opcionIngresada = Console.ReadLine();
    if (int.TryParse(opcionIngresada, out opcion))
    {
        switch (opcion)
        {
            case 5:
                Console.Write("Ingrese un numero para calcular el valor absoluto: ");
                Calculadora.ValorAbsoluto(Calculadora.PedirNumero());
                break;
            case 6:
                Console.Write("Ingrese un numero para calcular el cuadrado: ");
                Calculadora.Cuadrado(Calculadora.PedirNumero());
                break;
            case 7:
                Console.Write("Ingrese un numero para calcular la raiz cuadrada: ");
                Calculadora.RaizCuadrada(Calculadora.PedirNumero());
                break;
            case 8:
                Console.Write("Ingrese un numero para calcular el seno: ");
                Calculadora.Seno(Calculadora.PedirNumero());
                break;
            case 9:
                Console.Write("Ingrese un numero para calcular el coseno: ");
                Calculadora.Coseno(Calculadora.PedirNumero());
                break;
            case 10:
                Console.Write("Ingrese un numero para calcular su parte entera: ");
                Calculadora.ParteEntera(Calculadora.PedirNumero());
                break;
            case 11:
                Console.Write("Ingrese dos numeros para calcular el maximo: ");
                Calculadora.Maximo(Calculadora.PedirNumero(),Calculadora.PedirNumero());
                break;
            case 12:
                Console.Write("Ingrese dos numeros para calcular el minimo: ");
                Calculadora.Minimo(Calculadora.PedirNumero(),Calculadora.PedirNumero());
                break;
            case 0:
                Console.WriteLine("adios");
                break;
            default:
                Console.WriteLine("Ingrese una opcion del 5 al 12");
                break;
        }
    }
} while (opcion != 0);
