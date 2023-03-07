// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Programa que calcula el área de un rectángulo

double ladoA; //Declaracion de variable Explicita
var ladoB = 1.1; //Implicita
var resultado = 1.1;

Console.WriteLine("Calcula el área de un rectángulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultado);

