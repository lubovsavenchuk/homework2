// Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
// Знаю, что решение неверное, но оптимизировать его до выдачи одной третьей цифры числа любой продолжительности не смогла.

int k = new Random().Next(1, 65536);
Console.WriteLine(k);

while (k > 99)
{
   k /= 10;
   if(k > 99)
   {
      int digit3 = k % 10;
      Console.WriteLine(digit3);
   }
   if(k > 999)
   {
      int digit3 = k % 10;
      Console.WriteLine(digit3);
   }
   if(k > 9999)
   {
      int digit3 = k % 10;
      Console.WriteLine(digit3);
   }
   else 
   {
      Console.WriteLine("Третьей цифры нет");
   }
   
}