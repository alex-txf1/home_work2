Console.WriteLine("вывод третьего числа из произвольного числа");
Console.WriteLine("_______________________________");
int numbers = new Random().Next(0 , 200);
Console.WriteLine(numbers);
int A = 100;
found(numbers);
void found(int numbers)
{   
    if(numbers > A) 
    {
    string str = numbers . ToString();
    Console.WriteLine("третье число  "+str[2]);
    }  
    else{
        Console.Write("в числе "+numbers+ " нет цифры под третьим номером");
    }
}
    
