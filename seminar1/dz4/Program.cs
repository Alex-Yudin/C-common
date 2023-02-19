// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число положительное число N");
int Number = Convert.ToInt32(Console.ReadLine());
int count = 1;
System.Console.Write($"{Number} -> ");
while (count < Number)
{
    if (count % 2 == 0)
    {
        System.Console.Write($" {count} ");
    }
    else
    {
        System.Console.Write(" ");
    }

    count++;
}