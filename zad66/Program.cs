// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Recurse(int number)
{
    if (number < 1)
    {
        return 0;
    }

    return number%10 + Recurse(number/10);

}

// ---------------------------------------

int number = ReadInt("Введите число: ");

System.Console.WriteLine(Recurse(Math.Abs(number)));