// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalJugador = 25;
int totalDealer = 15;
string message = "";

//blackjack,, juntar 21 pidiendo, en caso de pasarte 21 pierdes, cartas o en caso de tener mas de 21 igual tener mayor puntuacion que el dealer

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "venciste al dealer, felicidades";
} else if (totalJugador >= 22)
{
    message = "perdiste vs el dealer te pasaste de 21";
} else if(totalJugador <= totalDealer) 
{
    message = "perdiste vs el dealer, lo siento";
} else 
{
    message = "condicion no valida";
}
Console.WriteLine(message);

