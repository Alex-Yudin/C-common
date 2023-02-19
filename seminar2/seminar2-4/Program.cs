/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите первое число");
int divider1 = Prompt("Введите первый делитель");
int divider2 = Prompt("Введите второй делитель");
if(number % divider1 == 0 && number % divider2 == 0)
{
    System.Console.WriteLine("Число кратное");
}
else
{
   System.Console.WriteLine($"число {number} не кратно числу {divider1} и числу {divider2}");
}
