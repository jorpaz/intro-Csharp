// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var radio = 0d;
var resultado = 0d;

Console.WriteLine("Bienvenido, calculemos circulos!");
//Pi * radio*radio

Console.WriteLine("Ingrese el valor del radio");

radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine("El area de tu circulo es de : " + resultado);
