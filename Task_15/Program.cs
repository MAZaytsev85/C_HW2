// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int value = Promt("Введите цифру от 1 до 7");
CheckDay(value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckDay (int day)
{
if (day < 1 || day > 7)
{
    Console.WriteLine("Веедена не верная цифра недели");
}
else if (day >=1 && day <=5) 
{
    Console.WriteLine("Сегодня еще не выходной, пора за работу");
}
else {
    Console.WriteLine("Выходной, можно и отдохнуть");
}
}
