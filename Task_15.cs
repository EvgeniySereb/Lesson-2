//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int input()
{
    Console.WriteLine("Введите число дня недели : ");
    int Digit = Convert.ToInt32(Console.ReadLine());
    return Digit;
}
void Sravnenie(int Digit)
{
    if(Digit >= 6 & Digit < 8 )
    {
        Console.WriteLine("Выходной");

    }
    else if(Digit > 7)
    {
        
        Console.WriteLine("Нет дня недели с таким номером");

    }
    else 
    {
       
        Console.WriteLine("Рабочий день");
    }
}
  int digit = input();
    Sravnenie(digit);
