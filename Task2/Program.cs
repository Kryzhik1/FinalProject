// Найти сумму элементов от M до N, N и M заданы.
Console.WriteLine( "Введите число N:" );
int N = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число M:" );
int M = int.Parse(Console.ReadLine());
int Sum = 0;
while ( N > M )
{
    Sum = Sum + M;
    M++;
}
while (N < M )
{
    Sum = Sum + M;
    M--;   
}

Console.WriteLine(Sum);