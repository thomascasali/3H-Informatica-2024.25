Console.WriteLine("Premi un tasto. Premi Esc per uscire.");

while (true)
{
    // Legge un tasto dalla console
    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // `true` evita di mostrare il tasto nella console

    switch (keyInfo.Key)
    {
        case ConsoleKey.RightArrow:
            Console.WriteLine("Hai premuto la freccia a destra!");
            break;
        case ConsoleKey.LeftArrow:
            Console.WriteLine("Hai premuto la freccia a sinistra!");
            break;
        case ConsoleKey.UpArrow:
            Console.WriteLine("Hai premuto la freccia in alto!");
            break;
        case ConsoleKey.DownArrow:
            Console.WriteLine("Hai premuto la freccia in basso!");
            break;
        default:
            Console.WriteLine($"Tasto premuto: {keyInfo.Key}");
            break;
    }

    if (keyInfo.Key == ConsoleKey.Escape) // Esce dal ciclo con Esc
    {
        Console.WriteLine("Uscita dal programma.");
        break;
    }
}