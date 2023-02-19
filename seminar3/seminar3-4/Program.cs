// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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

int number = InputInt("Введите число N, до которого считать квадраты");

for(int i = 1; i <= number; i++)     // У цикла for три параметра: 1. int i = 1 - это инициализация; 2. i <= number - условие продолжения; 3. Команда увеличения счетчика if++ -      
{
    int square = i * i;
    System.Console.Write($"{square} ");
}