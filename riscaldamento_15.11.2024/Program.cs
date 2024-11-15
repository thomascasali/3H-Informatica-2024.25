var vettore = new int[10]; //istanzio il vettore

for (int i=0; i<10; i++)
{
    vettore[i] = i;
}

int conta = 9;
for (int i = 0; i < 10; i++)
{
    vettore[i] = conta;
    conta--;
}

for (int i = 0; i < 10; i++)
{
    vettore[i] = 9-i;
}


Console.WriteLine("Inserimento completato");