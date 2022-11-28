int SumBetweenNAndM(int N, int M)
{
    int sum = 0;
    for (int i = N; i <= M; i++)
    {
        sum = sum + i;
    }
    return sum;
}


Console.WriteLine("This program assepts M and N and show sum of elements between N and M");
Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int summa = SumBetweenNAndM(M, N);
Console.WriteLine(summa);

