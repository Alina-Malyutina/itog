void PrintNumbersBetween1toN(int N, int count)
{
    if (count > N)
    {
        return;
    }
    else
    {
        PrintNumbersBetween1toN(N, count + 1);
        Console.Write(count + " ");
    }
}

Console.WriteLine("This program assepts number and show all numbers between 1 to N");
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumbersBetween1toN(N, count);


