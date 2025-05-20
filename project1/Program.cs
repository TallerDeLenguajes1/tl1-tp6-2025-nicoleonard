// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//codigo de prueba
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);
/// /// /// /// ///
//Ejercicio 1
Console.WriteLine("Ingrese un numero distinto de cero");
float Fnumero;
string? dato = Console.ReadLine();
if (float.TryParse(dato,out Fnumero) && Fnumero != 0)
{
    Fnumero = 1 / Fnumero;

    Console.WriteLine($"El numero es: {Fnumero}");
}
else
{
    Console.WriteLine("El numero debe ser distinto de 0");
}
