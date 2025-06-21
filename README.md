[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

Ejercicio 4
String es una clase, por lo tanto es un tipo por referencia.
Secuencias de escape de string:
\' 	Comilla simple 	
\" 	Comilla doble 	
\\ 	Barra invertida 	
\0 	Nulo 	
\a 	Alerta 	
\b 	Retroceso 	
\e 	Escapar 	
\f 	Avance de página 
\n 	Nueva línea 
\r 	Retorno de carro 
\t 	Tabulación horizontal 
\v 	Tabulación vertical 
\u 	Secuencia de escape Unicode (UTF-16)
\U 	Secuencia de escape Unicode (UTF-32)
\x  Secuencia de escape Unicode similar a "\u" excepto con longitud variable
$ antes de la cadena declara una cadena interpolada con una expresion interpolada entre llaves {}
El carácter @ de esta instancia define un literal de cadena textual. Las secuencias de escape sencillas, las hexadecimales y las Unicode se interpretan literalmente. Solo las comillas ("") no se interpretan literalmente, sino que generan comillas dobles. De igual modo, en el caso de una cadena interpolada literal, las secuencias de escape de llave no se interpretan literalmente, sino que generan caracteres de llave simple.

Expresiones regulares
Las expresiones regulares proporcionan un método eficaz, flexible y eficaz para procesar texto. La notación extensa de coincidencia de patrones de expresiones regulares permite analizar rápidamente grandes cantidades de texto.

Ejemplos:
    Buscar patrones de caracteres específicos.
    Validar el texto para asegurarse de que coincida con un patrón predefinido (por ejemplo, una dirección de correo electrónico).
    Extraer, editar, reemplazar o eliminar subcadenas de texto.
    Agregue cadenas extraídas a una colección para generar un informe.

Para muchas aplicaciones que tratan cadenas o que analizan bloques grandes de texto, las expresiones regulares son una herramienta indispensable.

Funcionamiento en c#
La pieza central del procesamiento de texto con expresiones regulares es el motor de expresiones regulares, que se representa mediante el System.Text.RegularExpressions.Regex objeto en .NET.