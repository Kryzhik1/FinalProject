// Написать программу вычисления функции Аккермана.
static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(1, 2)); // 4
Console.WriteLine(Akk(0, 0)); // 1
Console.WriteLine(Akk(4, 2)); // Stack Overflow !
