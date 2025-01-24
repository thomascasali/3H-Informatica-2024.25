/*
Crea un programma per simulare un carrello della spesa con le seguenti funzionalità:
Crea un metodo AggiungiAlCarrello che riceve in ingresso il valore totale del carrello per riferimento e il costo del prodotto aggiunto per valore. Nel metodo il costo del prodotto viene aggiunto al valore del carrello
Crea un metodo Stampa che riceve in ingresso un parametro stringa come valore e stampa in Console il testo ricevuto
Crea un metodo CalcolaTassa che accetti il totale del carrello per valore e restituisca l'importo della tassa (10%) applicata.
Crea un metodo StampaCarrello che riceve in ingresso l'importo totale del carrello e stampa l'imponibile (totale meno le tasse) e le tasse
*/

//variabili
double totaleCarrello=0; //totale del carrello
double prezzo = 0; //prezzo del prodotto da aggiungere
string ?scelta; //conterrà la scelta dell'utente sull'operazione da svolgere

do
{
    StampaScelte();
    scelta = Console.ReadLine();
    switch (scelta) { 
    
        case "1":
            Stampa("Inserisci il prezzo del protto da inserire nel carrello");
            prezzo = Convert.ToDouble(Console.ReadLine());
            AggiungiAlCarrello(ref totaleCarrello, prezzo);
            break;

        case "2":
            StampaTotaleCarrello(totaleCarrello);
            break;

        case "3":
            StampaTotaleCarrello(totaleCarrello);
            Stampa("Di cui " + Math.Round(CalcolaTassa(totaleCarrello),2) + " di tasse\n\n");
            break;

        case "4":
            StampaImponibileCarrello(totaleCarrello);
            break;


    }

} while (scelta != "0");

//main


//metodi
void AggiungiAlCarrello(ref double totC,double p)
{
    totC = totC + p;
}

void Stampa(string msg)
{
    Console.WriteLine(msg);
}
void StampaTotaleCarrello(double msg)
{
    Console.Write("Il totale del carrello è ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(msg.ToString());
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" euro\n");
}

void StampaScelte()
{
    Stampa("Cosa vuoi fare?");
    Stampa("1) Aggiungere un prodotto al carrello ");
    Stampa("2) Stampa il totale del carrello");
    Stampa("3) Stampa il totale del carrello con indicazione delle tasse");
    Stampa("4) Stampa il totale del carrello con il solo imponibile");
    Stampa("");
    Stampa("0) Esci dal programma");
}

double CalcolaTassa(double totC)
{
    double tassa = totC / 11; //tasse al 10%
    return tassa;
}

void StampaImponibileCarrello(double totC)
{
    Console.Write("Il totale IMPONIBILE del carrello è ");
    Console.ForegroundColor = ConsoleColor.Green;
    double imponibile = Math.Round(totC - CalcolaTassa(totC),2);
    Console.Write(imponibile.ToString());
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" euro\n");
}