//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int CreateNumber()
{
    int number = new Random().Next(10, 1000);
    return number;
}
int DelSecondDigit(int number)
{
    int Ed = number % 10;
     return Ed;
}
void Srav (int a)
{
if (a > 99)
{
int numberNew = DelSecondDigit(a);
Console.WriteLine(numberNew);
}
else if (a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
}


int a = CreateNumber();
Console.WriteLine(a);
Srav(a);
