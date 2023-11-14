Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string NumStr = number.ToString();


{
    if (NumStr[0] == NumStr[4]) 
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    if ((NumStr[0] > NumStr[4])|| (NumStr[0] < NumStr[4])) 
    {
       Console.WriteLine($"Число {number} HE является палиндромом");
    }
}