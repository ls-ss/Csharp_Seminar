// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0){
    Console.WriteLine($"{n} - четное число");
}
else {
    Console.WriteLine($"{n} - нечетное число");;
}