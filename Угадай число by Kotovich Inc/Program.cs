using static System.Net.Mime.MediaTypeNames;
while (true)
{
    Console.WriteLine(@"Выберите действие:
            1. Игра - Угадай число
            2. Таблица умножения 
            3. Вывод делителей числа
            4. Выход");
    string q = Console.ReadLine();

    if (q == "1")
    {

        {
            Console.WriteLine("игра - угадай число");
            Console.WriteLine("я загадал от 1 до 100 число! Попробуй угадать его");
            Random rnd = new Random();
            int i = rnd.Next(1, 100);
            string a;
            int count = 0;
            do
            {
                Console.Write("Ваш вариант: ");
                a = Console.ReadLine();

                if (int.Parse(a) < i)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(a) > i)
                    Console.WriteLine("Задуманное число меньше");

                count++;
            }
            while (int.Parse(a) != i);
            Console.WriteLine("Вы угадали с {0} попытки", count);
            Console.ReadLine();
        }
    }
    if (q == "2")
    {
        int[,] arr = new int[10, 10];
        for (int z = 1; z < arr.GetLength(0); ++z)
        {
            for (int x = 1; x < arr.GetLength(1); ++x)
            {

                int sum = z * x;
                if (z == x)
                {
                    arr[z, x] = sum;
                    Console.Write(arr[z, x] + "\t");
                }
                else if (z > x)
                {
                    arr[z, x] = sum;
                    Console.Write(arr[z, x] + "\t");
                }
                else if (z < x)
                {
                    arr[z, x] = sum;
                    Console.Write(arr[z, x] + "\t");
                }

            }
            Console.WriteLine("\n");
        }

    }
    if (q == "3")
    {
        string strA, res;
        Int32 intA1;
        Console.Write("Программа выведет все числа, на которое ваше число делиться без остатка. \r\n \r\nВведите число:");
        strA = Console.ReadLine();
        intA1 = Convert.ToInt32(strA);
        res = "";
        for (int i = 1; i <= intA1; i++)
        {
            if (intA1 % i == 0)
            { res += i + " "; }
        }
        Console.WriteLine("Все целые числа, на которое заданное число делиться без остатка: ");
        Console.Write(res);

        Console.ReadLine();
    }
    if (q == "4")
    {
        Environment.Exit(0);
    }
}