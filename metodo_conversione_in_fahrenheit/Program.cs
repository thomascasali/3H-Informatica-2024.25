//questo è già il main
double c = 10; //gradi celsius
double f; //conterrà la conversione

f = ConvertiFahrenheit(c); //chiamo il metodo di conversione passando il parametro 
Stampa(f.ToString()); //stampo il risultato

//posso fare anche tutto in una sola riga di chiamata
Stampa(ConvertiFahrenheit(20).ToString());

double ConvertiFahrenheit(double celsius)
{
    //la Formula per la conversione è: F = C * 9/5 + 32
    return celsius * 9 / 5 + 32;
}

void Stampa(string msg) //riceve una stringa che metto in msg
{
    Console.WriteLine(msg + "\n"); //stampo con ulteriore (\n) invio a capo
}