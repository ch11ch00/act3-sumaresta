// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, este es un programa en el que se pueden realizar operaciones de dos cifras");
Console.WriteLine ("Introduzca un número");
var primernumero=Console.WriteLine();
int num1 = int.Parse(primernumero);
Console.WriteLine("Introduce otro número");
var segundonumero=Console.WriteLine();
int numero2 = int.parse(segundonumero);
var suma=num1 +numero2;
Console.WriteLine("La suma total de"+ primernumero + "y" + segundonumero + "es:" + suma);
var resta=num1 - numero2;   
Console.WriteLine("La diferencia de"+ primernumero + "y" + segundonumero + "es:" + resta);
var producto=num1 * numero2;
Console.WriteLine("El producto de"+ primernumero + "y" + segundonumero + "es:" + producto);
var division=num1 / numero2;
Console.WriteLine("El resultado de dividir" + primernumero + "y" + segundonumero + "es" + division);

