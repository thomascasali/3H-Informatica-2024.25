// See https://aka.ms/new-console-template for more information
int lanci; //dichiaro la variabile lanci
int f1 = 0,f2=0,f3=0,f4=0,f5=0,f6=0; //dichiaro e inizializzo le variabili per memorizzare il numero di volte che è uscita una faccia
var rand = new Random(); //istanzio una variabile di tipo Random che si chiama rand
int facciaEstratta; //dichiaro variabile che memorizza l'estrazione

do
{
    Console.WriteLine("Inserisci il numero di volte che vuoi lanciare il dado (>0)");
    lanci = Convert.ToInt32(Console.ReadLine());
} while (lanci < 1);


for (int i=0;i<lanci;i++)
{
    facciaEstratta = rand.Next(1, 7);
    //if (facciaEstratta == 1) f1++;
    //if (facciaEstratta == 2) f2++;
    //if (facciaEstratta == 3) f3++;
    //if (facciaEstratta == 4) f4++;
    //if (facciaEstratta == 5) f5++;
    //if (facciaEstratta == 6) f6++;
    switch (facciaEstratta)
    {
        case 1:
            f1++;
            break;
        case 2:
            f2++;
            break;
        case 3:
            f3++;
            break;
        case 4:
            f4++;
            break;
        case 5:
            f5++;
            break;
        case 6:
            f6++;
            break;
    }

}

Console.WriteLine("La faccia 1 è stata estratta " + f1 + " volte");
Console.WriteLine("La faccia 2 è stata estratta " + f2 + " volte");
Console.WriteLine("La faccia 3 è stata estratta " + f3 + " volte");
Console.WriteLine("La faccia 4 è stata estratta " + f4 + " volte");
Console.WriteLine("La faccia 5 è stata estratta " + f5 + " volte");
Console.WriteLine("La faccia 6 è stata estratta " + f6 + " volte");

if (f1 >= f2 && f1 >= f3 && f1 >= f4 && f1 >= f5 && f1 >= f6) Console.WriteLine("La faccia che è uscita di più è la 1");
if (f2 >= f1 && f2 >= f3 && f2 >= f4 && f2 >= f5 && f2 >= f6) Console.WriteLine("La faccia che è uscita di più è la 2");
if (f3 >= f1 && f3 >= f2 && f3 >= f4 && f3 >= f5 && f3 >= f6) Console.WriteLine("La faccia che è uscita di più è la 3");
if (f4 >= f1 && f4 >= f2 && f4 >= f3 && f4 >= f5 && f4 >= f6) Console.WriteLine("La faccia che è uscita di più è la 4");
if (f5 >= f1 && f5 >= f2 && f5 >= f3 && f5 >= f4 && f5 >= f6) Console.WriteLine("La faccia che è uscita di più è la 5");
if (f6 >= f1 && f6 >= f2 && f6 >= f3 && f6 >= f4 && f6 >= f5) Console.WriteLine("La faccia che è uscita di più è la 6");

//Console.ReadKey();