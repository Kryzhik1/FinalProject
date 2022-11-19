// Показать натуральные числа от M до N, N и M заданы.
Console.WriteLine( "Введите число N:" );
int N = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число M:" );
int M = int.Parse(Console.ReadLine());
if (N>M)
{
while ( N > M )
{
Console.Write($"{M} ");
M++;
}
}
else while (N < M )
{
     Console.Write($"{M} ");
     M--;   
}