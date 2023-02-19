// Напишите программу, которая принимает на вход координаты точки (x, y), причем x и y не 
// равны нулю, и выдает номер четверти плоскости, в которой находится эта точка.


int InputInt(string message)
{
    System.Console.Write($"{message} > ");
    // bool isCorrect = int.TryParse(Console.Readline(), out value);//
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Одна из координат находится на оси");
        return false;
    }
    return true;
}

int GetQuortrer(int x, int y)                    // описываем функцию, которая возвращает номер четверти//
{
    if (x > 0 && y > 0)
    {
        return 1; //номер четверти
    }
    if (x < 0 && y > 0)
    {
        return 2; //номер четверти
    }
    if (x < 0 && y < 0)
    {
        return 3; //номер четверти
    }
    return 4; //номер четверти
}

int x = InputInt("Введите X");
int y = InputInt("Введите Y");

if (ValidateCoords(x, y))
{
    System.Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuortrer(x, y)}");
}