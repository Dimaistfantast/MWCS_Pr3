int[] PointOne = {7, -5};
int[] PointTwo = {1, -1};

double result = Math.Sqrt(Math.Pow((PointTwo[0] - PointOne[0]), 2) + Math.Pow((PointTwo[1] - PointOne[1]),2));

Console.WriteLine($"{result:f2}");
