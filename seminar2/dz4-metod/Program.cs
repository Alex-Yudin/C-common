// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число положительное число N");
int count = 2;
while (count <= number)
{
   
    System.Console.Write($" {count} ");
   
    count+=2;
}