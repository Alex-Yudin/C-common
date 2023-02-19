// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int InputInt(string message)
{
    System.Console.Write($"{message} > ");
       if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool ValidateChetvert(int chetvert)
{
    if (chetvert < 1 || chetvert > 4)
    {
        System.Console.WriteLine("Такой четверти не существует");
        return false;
    }
    return true;
}

(int, int) GetCoords(int chetvert)                 
{
    switch(chetvert)
    {
        case 1: return (1, 1);
        case 2: return (-1, 1);
        case 3: return (-1, -1);
        default: return (1, -1);
    }
}


int chetvert = InputInt("Введите номер четверти");


if (ValidateChetvert(chetvert))
{
    System.Console.WriteLine($"Номер четверти {chetvert} соответствует координатам  {GetCoords(chetvert)}");
}