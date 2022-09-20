//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CreateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int Del(int number)
{
    int Sot = number / 10;
    int Desyatki = Sot % 10;

    
    return Desyatki ; 
}

int a = CreateNumber();
Console.WriteLine(a);
int numberNew = Del(a);
Console.WriteLine(numberNew);