// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string DayOfWeek = Console.ReadLine();
int Day = Convert.ToInt32(DayOfWeek);
if (Day < 6)
{
   Console.WriteLine("Этот день рабочий");
}
else 
{
   Console.WriteLine("Этот день выходной");
}