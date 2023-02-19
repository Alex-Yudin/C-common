// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write("введите первое число >"); // Вывод в консоль
string inputValue1 = Console.ReadLine();
Console.Write("введите второе число >"); // Вывод в консоль
string inputValue2 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1); // Конвертация в целое введеннной строки
int value2 = Convert.ToInt32(inputValue2);

if (value2 == value1 * value1)
{
    System.Console.WriteLine($"Число {value2} является квадратом числа {value1}");
}
else
{
    System.Console.WriteLine($"Число {value2} не является квадратом числа {value1}");
}
