// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string message)        // Создаем метод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = Prompt("Введите первое число");
int number2 = Prompt("Введите второе число");
int number3 = Prompt("Введите третье число");

int maxNumber = number1;
if(maxNumber < number2)
{
    maxNumber = number2;
}
if(maxNumber < number3)
    {
    maxNumber = number3;
   
    }
System.Console.WriteLine($"max= {maxNumber}");