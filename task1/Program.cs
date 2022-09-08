int M = 1;
int N = 13;
PrintNumbers(M, N);

void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        m++;
        PrintNumbers(m, n);
    }
}
