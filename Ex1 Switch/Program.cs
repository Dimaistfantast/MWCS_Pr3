Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 6: {
        Console.WriteLine("Это Saturday!");
        break;
    }
    case 7: {
        Console.WriteLine("Это Sunday!");
        break;
    }
    default: {
        Console.WriteLine("Это будний день!");
        break;
    }
}
