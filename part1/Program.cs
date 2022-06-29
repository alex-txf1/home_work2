Console.WriteLine("вывод произвального трехзначного числа");
Console.WriteLine("_______________________________");
int start = 100;
int stop = 999;
int A = secondNumber(start , stop);
Console.WriteLine("вторая цифра  " + A);

int secondNumber(int start , int stop)
{    
    int number = new Random().Next(start , stop);
    Console.WriteLine(number);
    int secnum = number % 100;
    int secnum1 = secnum / 10;
    return secnum1;
}