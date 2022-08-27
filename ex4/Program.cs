// Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.

int RandomNumber = new Random().Next(1, 1000000);
Console.WriteLine(RandomNumber);
int Result = RandomNumber / (23 * 7);
if (Result == 0)
{
   Console.WriteLine("Кратно");

}
else
{
   Console.WriteLine("Не кратно");
}