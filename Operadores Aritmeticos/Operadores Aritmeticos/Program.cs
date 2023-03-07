// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Otro programa que calcule el area de un rectangulo

var ladoA = 0d; //Declaracion de variables
var ladoB = 0d;
var resultado = 0d;

Console.WriteLine("Calcula el area de un rectangulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

//ladoA++; //le suma + 1, operador de incremento => ladoA = ladoA + 1;
//ladoA--; //le resta -1, operador de decremento;
//Multiplicacion => ladoA * ladoB;
//Division =>  ladoA / ladoB;
// El residuo de una division => ladoA % ladoB

resultado = ladoA * ladoB;
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultado);
