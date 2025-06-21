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

//ejercicio 2 y ejercicio 3
Console.WriteLine("Ejercicio 2 y 3");

int opcion=0;
do
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
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
                do
                {
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
                Console.WriteLine("Ingrese una opcion del 0 al 12");
                break;
        }
    }

    if (opcion != 0)
    {
        Console.WriteLine("Quiere realizar otra operacion?");
        Console.WriteLine("1. SI");
        Console.WriteLine("0. NO");
        string otra = Console.ReadLine();
        int.TryParse(otra, out opcion);
    }
    
} while (opcion != 0);

Console.WriteLine("Ejercicio 4");
Console.Write("Ingrese una cadena de caracteres: ");
string cadena = Console.ReadLine();
Console.WriteLine($"Longitud de la cadena: {cadena.Length}");
Console.Write("Ingrese otra cadena de caracteres para concatenar: ");
string otraCadena = Console.ReadLine();
otraCadena = string.Concat(cadena, otraCadena);
Console.WriteLine($"Cadena concatenada: {otraCadena}");
Console.WriteLine($"Subcadena: {cadena.Substring(cadena.Length / 2)}");
float num1 = 4;
float num2 = 12;
string resultado = Calculadora.Suma(num1, num2).ToString();
Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");
foreach (var caracter in cadena)
{
    Console.Write(caracter);
    Console.Write(" ");
}
Console.WriteLine();
Console.WriteLine("Ingrese una cadena para buscar en la cadena inicial.");
string busca = Console.ReadLine();
Console.WriteLine(cadena.Contains(busca));
Console.WriteLine(cadena.ToUpper());
Console.WriteLine(cadena.ToLower());
string cadenaParaSeparar = "chorizos,morcillas,costillas,vacio,tapa de asado,matambre de cerdo";
string[] cadenaSeparada = cadenaParaSeparar.Split(",");
foreach (var subcadena in cadenaSeparada)
{
    Console.WriteLine(subcadena);
}
bool otraotra = false;
do
{
    Console.WriteLine("Ingrese una ecuacion simple. Por ejemplo 582+2");
    string ecuacion = Console.ReadLine();
    Calculadora.CalcularEcuacionSimple(ecuacion);
    Console.WriteLine("Quiere ingresar otra ecuacion?");
    Console.WriteLine("1. Si");
    Console.WriteLine("0. No");
    if (Console.ReadLine() == "1")
    {
        otraotra = true;
    }
    else
    {
        otraotra = false;
    }

} while (otraotra);