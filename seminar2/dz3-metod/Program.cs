// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int userNumber = Prompt("Введите число для проверки его четности > ");

if (userNumber % 2 == 0) 
{
    System.Console.Write($"{userNumber} -> четное число");
}
else
{
System.Console.Write($"{userNumber} -> не четное число");
}