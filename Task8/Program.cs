// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое положительное число больше 1: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Список четных чисел: ");
int count = 2;
while (count <= n){
    if (count % 2 == 0){
        Console.Write($"{count}, ");
    }
    count++;
}
Console.WriteLine("");