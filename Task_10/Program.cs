// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int value = Promt("Введите трехзначное число");
ChekValue(value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

void ChekValue (int x){
if (x >= 100 && x <1000) {

    x = (x % 100)/10;
    Console.WriteLine(x);
}
else {
    Console.WriteLine("ошибка");
}
}

