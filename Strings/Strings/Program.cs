// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.VisualBasic;

Console.WriteLine("Ricardo Perez ID!");

//Informacion de una persona
int altura = 168;
int edad = 89;
string nombre = "Jorge Paz";
string informacion = "Nacio en Guatemala, es estudiante de ingenieria";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"La informacion de {nombre}"
    + $" es la siguiente \n Su edad es {edad}, su altura es de {altura}\n" +
    $"Informacion relevante {informacion} \n Ademas, su hobby es ser {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);
