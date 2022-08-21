// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > num1){
    max = num2;
}

Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 == num2 && num1 == num3){
    Console.WriteLine($"Все числа одинаковы и равны: {num1}");
}
else if (num3 > max){
    max = num3;
    Console.WriteLine($"Максимальное число: {max}.");
}
else {
    Console.WriteLine($"Максимальное число: {max}.");
}