// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();//Esto para generar un numero aleatorio

//Blackjack, juntar 21 pidiendo cartar o en caso de que sea menos  tener mayor puntuacion que el dealer
//Si te pasas de 21 pierdes

while (true)
{
    totalJugador = 0;
    totalDealer = 0;

    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Bienvenido al C A S I N O");
            Console.WriteLine("Escriba '21' para jugar al 21");
            switchControl = Console.ReadLine();
            break;

        case "21":

            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma una carta");
                Console.WriteLine($"Te salio el numero: {num} ");
                if (num>0) { Console.WriteLine($"En total: {totalJugador} "); }
                Console.WriteLine("Deseas otra carta? (Si o No)");
                controlOtraCarta = Console.ReadLine().ToLower();

            } while (controlOtraCarta == "si");

            totalDealer = random.Next(14, 23);
            Console.WriteLine($"El dealer tiene {totalDealer}");

            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al dealer, felicidades!";
                switchControl = "menu";
            }
            else if (totalJugador >= 22)
            {
                message = "Perdiste vs el dealer, te pasaste de 21.";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = "Perdiste vs el dealer, lo siento";
                switchControl = "menu";
            }
            else
            {
                message = "Condicion no valida.";
                switchControl = "menu";
            }

            Console.WriteLine(message);
            break;

        default:

            Console.WriteLine("Valor ingresado no valido en el C A S I N O");
            break;
    }
}