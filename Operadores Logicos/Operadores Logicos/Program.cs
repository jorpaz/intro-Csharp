// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//bool valor1 = true;
//bool valor2 = false;
//bool valor3 = false;

//Esta es otra forma para declarar las variables, es lo mismo de lo que esta arriba
var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

bool resultXor = valor1 ^ valor2 ^ valor3; //Falso
Console.WriteLine(resultXor);


// && Y and 
// || O or
// ! Negacion
// ^ Xor compara valores e indica si son diferentes(Verdadero) o iguales(Falso)
