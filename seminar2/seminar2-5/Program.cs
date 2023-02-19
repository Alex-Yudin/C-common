/*Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.*/

int number = new Random().Next(10, 10000);
System.Console.WriteLine(number);
int maxNumber = 0;
while(number > 0)
{
    if(maxNumber < number % 10)
    {
        maxNumber = number % 10;
    }
    number /= 10;
}

System.Console.WriteLine($"Большая цифра {maxNumber}");