// Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

int x = new Random().Next(100, 1000);
Console.WriteLine(x);

while (x > 99)
{
   x /= 10;
}
int digit2 = x % 10;
Console.WriteLine(digit2);