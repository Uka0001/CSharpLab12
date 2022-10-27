// See https://aka.ms/new-console-template for more information

/* Остання цифра 2
 * Завдання на максимальну оцінку "добре"
 * Умова:
 * Дано натуральне число. Встановити, чи є
 * послідовність його цифр при перегляді їх
 * зліва направо впорядкованою за зростанням.
 * Наприклад, для числа 1478 відповідь позитивна,
 * для чисел 1782 і 1668 - негативна і т. д.
 */

/*
class Task2
{
    static bool IsCorrectOrder(int n)
    {
        
        int prev = 11;

        int number;
        
        while (n > 0)
        {
            number = n % 10;
            if (number == prev | number > prev )
            {
                return false;
            }
            prev = number;

            n = n / 10;
        }

        return true;
    }
    
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsCorrectOrder(n));
    }
}*/