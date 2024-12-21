var tabellone = new bool[91]; //andava bene anche int
var cartella = new int[15]; //istanzio una singola cartella
var rnd = new Random();
int totEstratti = 0;
int estratto; //numero estratto
ConsoleKeyInfo keyInfo; 

//inizializzo il vettore tabellone
for (int i = 1; i < 91; i++) tabellone[i] = false;

//creo una cartella, nella versione semplice un vettore casuale di 15 posti
//nei quali ipotizzo i numeri suddivisi in gruppi di 5 per simulare
//cinquina, decina e tombola
for (int i = 0; i <15 ; i++) cartella[i] = rnd.Next(1,91);
//stampa della cartella

do //ciclo generale di estrazione numeri
{
    Console.Clear();
    //stampa del tabellone attuale
    for (int i = 1; i < 91; i++)
    {
        if (i < 10) Console.Write(" ");
        if (tabellone[i]==true)
        {
            //se il numero è stato estratto lo stampo in rosso
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.Write(i + " ");
        }
        //vado a capo ogni 10 numeri estratti
        if (i % 10==0) Console.WriteLine();
    }

    Console.WriteLine("\nQuesta è la tua cartella:");
    for (int i = 0; i < 15; i++)
    {
        if (cartella[i]>-9 && cartella[i] < 10) Console.Write(" ");
        if (cartella[i]<0) Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(Math.Abs(cartella[i]) + " ");
        Console.ForegroundColor = ConsoleColor.White;
        if (i==4||i==9) Console.WriteLine();
    }
    Console.WriteLine();


    Console.WriteLine("");
    //chiedi la pressione di un tasto per fare l'estrazione
    Console.WriteLine("Premi lo spazio per estrarre un numero");
    do
    {
        keyInfo = Console.ReadKey(intercept: true);
    } while (keyInfo.Key!=ConsoleKey.Spacebar);

    //estraggo il numero controllando che non sia già stato estratto
    do
    {
        estratto = rnd.Next(1, 91);
    } while (tabellone[estratto] == true);
    //confermo che il numero è stato estratto
    tabellone[estratto] = true;

    //stampa il numero estratto
    Console.Write("Il numero estratto è:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(estratto);
    Console.ForegroundColor = ConsoleColor.White;
    totEstratti++;

    //cerco il numero estratto nella cartella e se c'è lo metto in negativo per segnare che è stato estratto
    for (int i = 0; i < 15; i++)
    {
        if (cartella[i] == estratto) cartella[i] = -cartella[i];
    }
    //qua bisogna aggiungere la logica per la ricerca della vittoria

    Console.WriteLine("\n");
    //chiedi la pressione di un tasto per fare l'estrazione
    Console.WriteLine("Premi lo spazio per vedere il tabellone aggiornato");
    do
    {
        keyInfo = Console.ReadKey(intercept: true);
    } while (keyInfo.Key != ConsoleKey.Spacebar);

} while (totEstratti < 90);
