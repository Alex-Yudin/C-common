/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет   */

int Prompt(string message)        // МЕТОД 1. Ввод значения
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int weekDay = Prompt("Введите число, соответствующее дню недели");

bool weekend(int weekDay) // МЕТОД 2. проверяется, если день недели больше 5, то это выходной день, если меньше - то рабочий
{
    if(weekDay > 5)
    {
        return true;
    }
    return false;
}

bool validateWeekDay(int number)  // МЕТОД 3. проверяется, чтобы вводимое число было в пределах от 1 до 7
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    return false;
}

if(validateWeekDay(weekDay))   // проверяем соответствует ли число weekday выходному или рабочему дню. Выводим на экран соответствующее значение 
{
    if(weekend(weekDay))
    {
        System.Console.WriteLine("выходной");
    }
    else
    {
        System.Console.WriteLine("рабочий день");
    }
}
else 
    {
        System.Console.WriteLine($"Число {weekDay} не является днем недели, введите число заново");
    }