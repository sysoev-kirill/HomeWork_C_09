// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Задайте число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N ");
int n = Convert.ToInt32(Console.ReadLine());


int Akerman(int n, int m)
{
   if (n == 0) return m + 1;
   else if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
   else
      return Akerman(n - 1, Akerman(n, m - 1));
}

Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {Akerman(m, n)}");