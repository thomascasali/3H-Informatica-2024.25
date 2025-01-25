//main
int numero = 42;

unsafe { 
    Console.WriteLine("Prima della chiamata al metodo per valore:");
    Console.WriteLine($"Value: {numero}, Address: {(long)&numero:X}");
}

PassaggioPerValore(numero); //chiamata al metodo con passaggio di parametro per valore

unsafe
{
    Console.WriteLine("\nDopo la chiamata al metodo per valore e prima della chiamata per riferimento:");
    Console.WriteLine($"Value: {numero}, Address: {(long)&numero:X}");
}

PassaggioPerRiferimento(ref numero); //chiamata al metodo con passaggio di parametro per riferimento

unsafe
{
    Console.WriteLine("\nDopo la chiamata al metodo per riferimento:");
    Console.WriteLine($"Value: {numero}, Address: {(long)&numero:X}");
}

//metodi
unsafe void PassaggioPerValore(int num)
{
    Console.WriteLine("\nAll'interno di PassaggioPerValore:");
    Console.WriteLine($"Valore: {num}, Indirizzo: {(long)&num:X}");
    num = 100; // Modifica locale, non rifletterà nel chiamante
}

unsafe void PassaggioPerRiferimento(ref int num)
{
    Console.WriteLine("\nAll'interno di PassaggioPerRiferimento:");
    fixed (int* p = &num)
    {
        Console.WriteLine($"Valore: {num}, Indirizzo: {(long)p:X}");
    }
    num = 200; // Modifica rifletterà nel chiamante
}