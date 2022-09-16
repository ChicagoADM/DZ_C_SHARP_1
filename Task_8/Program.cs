//Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число больше '0': ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
while(num2 <= num)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 2;
}