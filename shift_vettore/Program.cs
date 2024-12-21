var vettore = new int[10];
Random rnd = new Random();
int aux; //variabile di supporto

for (int i = 0; i < 10; i++)
{
    vettore[i] = rnd.Next(1, 100);
    Console.Write(vettore[i] + " ");
}


while (true)
{
    // Legge un tasto dalla console
    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // `true` evita di mostrare il tasto nella console

    switch (keyInfo.Key)
    {
        case ConsoleKey.RightArrow:
            //fare lo shift a destra del vettore
            aux = vettore[9]; //salvo il valore dell'ultima posizione
            for (int i = 9; i > 0; i--)
            {
                vettore[i] = vettore[i-1];
            }
            vettore[0] = aux; //metto il valore dell'ultimo posto all'inizio
            Console.WriteLine("");
            for (int i = 0; i < 10; i++) Console.Write(vettore[i] + " ");
            break;
        case ConsoleKey.LeftArrow:
            //fa lo shift a sinistra del vettore
            aux = vettore[0]; //salvo il valore della prima posizione
            for (int i = 0; i < 9; i++)
            {
                vettore[i] = vettore[i+1];
            }
            vettore[9] = aux; //metto il valore della prima posizione nell'ultima
            Console.WriteLine("");
            for (int i = 0; i < 10; i++) Console.Write(vettore[i] + " ");
            break;
        default:
            break;
    }

    if (keyInfo.Key == ConsoleKey.Escape) // Esce dal ciclo con Esc
    {
        Console.WriteLine("Uscita dal programma.");
        break;
    }
}