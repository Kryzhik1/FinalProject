// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.
Console.WriteLine( "Введите число A:" );
int A = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число B:" );
int B = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число N:" );
int N = int.Parse(Console.ReadLine());
/*int sum = B + A;
Console.Write($"Результат:{A} {B} ");
while (sum <N)
{
   Console.Write($"{sum} ");
   B = sum + A;
   A = sum;
   sum = B; 
}*/
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    int i = 0;
    array[i] = B;
    array[i-1] = A;
   int sum = array[i] + array[i-1];
    while (index < N)
    {
    array[index] = sum;
    array[i] = sum + array[i-1];
    array[i-1] = sum;
    sum = array[i];
    index++;
    i++;
    }
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}
}
int [] array = new int [N];
FillArray(array);
//for (int i=0; i<N; i++)
PrintArray(array);


