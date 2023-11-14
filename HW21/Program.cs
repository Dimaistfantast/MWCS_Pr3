int[] PointOne = {7,-5, 0};
int[] PointTwo = {1,-1,9};

double result = Math.Sqrt(Math.Pow((PointTwo[0] - PointOne[0]), 2) + Math.Pow((PointTwo[1] - PointOne[1]),2)+ Math.Pow((PointTwo[2] - PointOne[2]),2));

Console.WriteLine($"{result:f2}");