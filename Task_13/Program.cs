// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int value = Promt("Введите число");
ChekValue(value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ChekValue (long x)
{
if (x >= -99 && x <= 99) 
{
Console.WriteLine("Введено не верное число");
}
else if(x>0) 
{
 while (x>999) 
x = x/10;
x = x%10;
Console.WriteLine(x);
}
else if (x<0) 
{
while (x < -999) 
x = x/10;
x = x%10;
Console.WriteLine(x);
}
}

