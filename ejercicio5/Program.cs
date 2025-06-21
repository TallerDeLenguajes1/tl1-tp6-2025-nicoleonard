using System.Text.RegularExpressions;

//expresion regular para validar mails
string[] arregloDeMails = ["correoinvalido.com", "correovalido@algo.com", "otroinvalido@algo", "otro_valido@algo.net"];
string expresionRegularParaEmail = @"^\S+@\S+\.\S{2,}$";
foreach (string mail in arregloDeMails)
{
    if (Regex.IsMatch(mail, expresionRegularParaEmail))
        Console.WriteLine($"{mail} es un mail valido.");
    else
        Console.WriteLine($"{mail} no es un mail valido");
}
Console.WriteLine("--------------");

string[] arregloDeDirecciones = ["https://www.google.com", "www.google.com","google.com", "com.google", "Avenida independencia 1800","https://facetvirtual.facet.unt.edu.ar/course/view.php?id=115"];
string expresionRegularParaDireccionesWeb = @"^(https?|ftp):\/\/[^\s\/$.?#].[^\s]*$";
foreach (string direccion in arregloDeDirecciones)
{
    if (Regex.IsMatch(direccion, expresionRegularParaDireccionesWeb))
        Console.WriteLine($"{direccion} es una direccion web valida.");
    else
        Console.WriteLine($"{direccion} no es una direccion web valida");
}