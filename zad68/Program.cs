// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// m=0 -> n+1
// m>0, n=0 -> F(m-1,1)
// m>0, n>0 -> F(m -1, F(m.n-1))
// проверка по таблице - https://wiki5.ru/wiki/Ackermann_function#Table_of_values 

// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int akkermanF(int m, int n)
{
    if (m == 0)
    { return n + 1; }
    else if ((m != 0) && (n == 0))
    { return akkermanF(m - 1, 1); }
    else
    { return akkermanF(m - 1, akkermanF(m, n - 1)); }
}

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для {m} и {n} равна {akkermanF(m, n)} ");