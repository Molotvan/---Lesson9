int M = 1;
int N = 15;
Console.WriteLine(Sum(M, N));

int Sum(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= N; i++)
    {
        sum = sum + i;
    }
    return sum;
}