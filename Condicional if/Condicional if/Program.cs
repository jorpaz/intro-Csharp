// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugador = 25;
int totalDealer = 15;
string message = "";

//Blackjack, juntar 21 pidiendo cartar o en caso de que sea menos  tener mayor puntuacion que el dealer
//Si te pasas de 21 pierdes

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste al dealer, felicidades!";
}
else if (totalJugador < totalDealer)
{
    message = "Perdiste vs el dealer, lo sentimos!";
}
else
{
    message = "Condicion no valida.";
}

Console.WriteLine(message);