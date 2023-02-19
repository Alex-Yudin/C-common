/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6   */

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");

int thirdNumber = 0;
if(number / 100 % 10 > 0)
{
    thirdNumber = number / 100 % 10;
    System.Console.WriteLine($"Третья цифра числа {number} -> {thirdNumber}");
}
else
{
    System.Console.WriteLine($"Третьей цифры числа {number} не существует");
}

