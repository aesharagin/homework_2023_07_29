/*Задача 1: Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
N = 5, M = 9 -> "6, 8"
N = 2, M = 10 -> "2, 4, 6, 8, 10"*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
      if (count > n)
    {
        return;
    }
    
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + "Четное");
    }
}
