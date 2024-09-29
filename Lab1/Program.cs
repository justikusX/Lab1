try
{
    Console.WriteLine("Введите число K: ");
    int K = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число x: ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число a: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число b: ");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число y: ");
    int y = int.Parse(Console.ReadLine());

    double D = Math.Pow(K, Math.Asin(-x)) - (a * Math.Sqrt(6)) - (Math.Cos(3 * a * b)) / (Math.Sin(a * Math.Asin(x) + Math.Log10(y))) + (Math.Cos(a * Math.Asin(x) + Math.Log10(y)));
    Console.WriteLine($"Ввывод : D = {D:F2}");
}
catch
{
    Console.WriteLine("Error");
}