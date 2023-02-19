/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = Prompt("Введите первое число");
int number2 = Prompt("Введите второе число");
int ostatok = number2 % number1;
if(ostatok == 0)
{
    System.Console.WriteLine("Число кратное");
}
else
{
   System.Console.WriteLine($"число {number1} не кратно числу {number2}, остаток от деления равно {ostatok}");
}