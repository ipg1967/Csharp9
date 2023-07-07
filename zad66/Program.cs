// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}
// возвращаем очередной  M пока не достигнем N
int RecurseSumMN(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + RecurseSumMN(M + 1, N);
}

// ---------------------------------------

int[] number = ReadInt("Задайте начальное и конечное значения через запятую: ");
System.Console.WriteLine(RecurseSumMN(number[0], number[1]));