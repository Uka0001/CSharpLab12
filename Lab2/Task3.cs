/*
 * Остання цифра: 2
 * Завдання на максимальну оцінку "відмінно"
 * Дано натуральне число. Якщо в ньому є цифри
 * а і b, то визначити, яка з них розташована в
 * числі правіше. Якщо одна або обидві ці цифри зустрічаються
 * в числі кілька разів, то повинні бути розглянуті останні з однакових цифр
 */

/*
class Task3
{
    static void whatNumerOnRight(int x, int a, int b)
    {
        while (x > 0)
        {
            int rem = x % 10;
            if (rem == a)
            {
                Console.WriteLine("number a - " + a + " on the right of x earlier than b - " + b);
                break;
            }
            else if (rem == b)
            {
                Console.WriteLine("number b - " + b + " on the right of x earlier than a - " + a);
                break;
            }
            else
            {
                Console.WriteLine("There is no number a - " + a + " or b - " + b + " in last digit of x ");
            }

            x = x / 10;
        }
    }
    
    public static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());

        int a = Convert.ToInt32(Console.ReadLine());

        int b = Convert.ToInt32(Console.ReadLine());

        whatNumerOnRight(x, a, b);
    }
}*/