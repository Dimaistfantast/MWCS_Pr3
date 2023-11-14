Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1: {
        Console.WriteLine("X > 0, Y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("X < 0, Y > 0");
        break;
    }
    case 3: {
        Console.WriteLine("X < 0, Y < 0");
        break;
    }
    case 4: {
        Console.WriteLine("X > 0, Y < 0");
        break;
    }
    default: {
        Console.WriteLine("Ошибка");
        break;
    }
}
