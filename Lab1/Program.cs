using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод данных
        Console.Write("Введите накопления (S) в грн: ");
        decimal S = decimal.Parse(Console.ReadLine());

        Console.Write("Введите ежемесячную стипендию (A) в грн: ");
        decimal A = decimal.Parse(Console.ReadLine());

        Console.Write("Введите ежемесячные расходы на проживание (B) в грн: ");
        decimal B = decimal.Parse(Console.ReadLine());

        // Параметры
        decimal inflationRate = 0.03m; // 3% рост цен
        int months = 0; // Количество месяцев

        // Расчет
        while (S + A > B)
        {
            months++;
            // Уменьшаем накопления на текущие расходы
            S = S + A - B;

            // Увеличиваем расходы на 3%
            B *= (1 + inflationRate);
        }

        // Вывод результата
        Console.WriteLine($"Студент сможет прожить {months} месяцев.");
    }
}
