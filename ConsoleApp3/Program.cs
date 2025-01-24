int eta = 10;

if (IsMaggiorenne(eta))
{
    Console.WriteLine("Maggiorenne");
}
else
{
    Console.WriteLine("Minorenne");
}

bool IsMaggiorenne(int e)
{
    if(e>=18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

