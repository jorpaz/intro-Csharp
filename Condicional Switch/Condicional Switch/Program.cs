// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugador = 25;
int totalDealer = 15;
string message = "";
string switchControl = "21";

//Blackjack, juntar 21 pidiendo cartar o en caso de que sea menos  tener mayor puntuacion que el dealer
//Si te pasas de 21 pierdes

switch (switchControl)
{
    case "menu":
        Console.WriteLine("Bienvenido al C A S I N O");
        Console.WriteLine("Escriba '21' para jugar al 21");
        switchControl = Console.ReadLine();
        break;

    case "21":

            if (totalJugador > totalDealer && totalJugador < 22)
        {
            message = "Venciste al dealer, felicidades!";
        }
            else if (totalJugador >= 22)
        {
            message = "Perdiste vs el dealer, lo sentimos!";
        }
            else
        {
            message = "Condicion no valida.";
        }

    Console.WriteLine(message);
        break;

        default;
        Console.WriteLine("Valor ingresado no valido en el C A S I N O");
        break;
}
