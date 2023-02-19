// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число N");
int Number = Convert.ToInt32(Console.ReadLine());
int count = - Number;
while(count < Number)
{
    System.Console.Write($" {count} ");
    count ++;
}