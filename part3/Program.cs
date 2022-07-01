Console.WriteLine("проверка наличия выходного");
Console.WriteLine("_______________________________");
Console.Write("введите номер дня недели  ");
int daynum = Convert.ToInt32(Console.ReadLine());
int[] dayList = new int[]{1 , 2 , 3 , 4 , 5};
int[] dayList1 = new int[]{6 , 7};
foundDay(daynum);
void foundDay(int daynum)
{
    if(dayList.Contains(daynum))  
    {
        Console.WriteLine("сегодня рабочий день");
    }
    if(dayList1.Contains(daynum))  
    {
        Console.WriteLine("поздравляю сегодня выходной");
    }
    else{
        Console.Write("дней недели всего 7, а не сколько вы написали");
    }
}
