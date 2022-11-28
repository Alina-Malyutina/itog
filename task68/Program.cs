int AkkermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else
    {
        if (N == 0 && M > 0)
        {
            return AkkermanFunction(M - 1, 1);
        }
        else
        {
            return (AkkermanFunction(M - 1, AkkermanFunction(M, N - 1)));
        }
    }
}

void CallAkkermanFunction(int M, int N)
{
    Console.Write(AkkermanFunction(M, N));
}

Console.WriteLine("This program assepts two positive numbers M and N and count Akkerman function");
Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

CallAkkermanFunction(M, N);
