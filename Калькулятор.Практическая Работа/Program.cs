start1:
Console.WriteLine("Выберите какое действие хотите выполнить: ");
Console.WriteLine("1. Сложить 2 числа ");
Console.WriteLine("2. Вычесть первое из второго ");
Console.WriteLine("3. Перемножить два числа ");
Console.WriteLine("4. Разделить первое на второе ");
Console.WriteLine("5. Возвести первое число в степень из второго числа ");
Console.WriteLine("6. Найти квадратный корень из числа ");
Console.WriteLine("7. Найти 1 процент от числа ");
Console.WriteLine("8. Найти факториал из числа ");
Console.WriteLine("9. Выйти из программы ");

st:
int a = Convert.ToInt32(Console.ReadLine());
while (a != 9)
{
    if (a == 1)
    {
        Console.WriteLine("Введите первое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.WriteLine(b + " + (" + c + ") = " + b + " - " + (c * -1) + " = " + (b + c));
            goto start;
        }
        else
        {
            Console.WriteLine(b + " + " + c + " = " + (b + c));
            goto start;
        }
    }
    if (a == 2)
    {
        Console.WriteLine("Введите первое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.WriteLine(b + " - (" + c + ") = " + b + " + " + (c * -1) + " = " + (b - c));
            goto start;
        }
        else
        {
            Console.WriteLine(b + " - " + c + " = " + (b - c));
            goto start;
        }
    }
    if (a == 3)
    {
        Console.WriteLine("Введите первое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.WriteLine(b + " * (" + c + ") = " + (b * c));
            goto start;
        }
        else
        {
            Console.WriteLine(b + " * " + c + " = " + (b * c));
            goto start;
        }
    }
    if (a == 4)
    {
        Console.WriteLine("Введите первое число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double c = Convert.ToDouble(Console.ReadLine());
        if (c == 0)
        {
            goto finish1;
        }
        if (c < 0)
        {
            Console.WriteLine(b + " / (" + c + ") = " + (b / c));
            goto start;
        }
        else
        {
            Console.WriteLine(b + " / " + c + " = " + (b / c));
            goto start;
        }
    }
    if (a == 5)
    {
        Console.WriteLine("Введите первое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("Введите второе число");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            Console.WriteLine(b + " ^ (" + c + ") = " + (Math.Pow(b, c)));
            goto start;
        }
        else
        {
            Console.WriteLine(b + " ^ " + c + " = " + (Math.Pow(b, c)));
            goto start;
        }
    }
    if (a == 6)
    {
        Console.WriteLine("Введите число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b < 0)
        {
            goto finish3;
        }
        else
        {
            Console.WriteLine("Квадратный корень из " + b + " = " + (Math.Sqrt(b)));
            goto start;
        }
    }
    if (a == 7)
    {
        Console.WriteLine("Введите число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("1% числа " + b + " = " + (b / 100));
        goto start;
    }
    if (a == 8)
    {
        Console.WriteLine("Введите число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b < 1)
        {
            goto finish3;
        }
        else
        {
            int d = b;
            int c = b;
            do
            {
                b = b * (c - 1);
                c--;
            } while (c > 1);
            Console.WriteLine(d + "! = " + b);
            goto start;
        }
    }
    if (a == 9)
    {
        Environment.Exit(0);
    }
    else
    {
        goto finish;
    }
start:
    Console.WriteLine("Выберите действие еще раз");
    goto st;
finish:
    Console.WriteLine("Вы выбрали неправильное дейстивие, попробуйте снова...");
    Thread.Sleep(5000);
    goto start1;
finish1:
    Console.WriteLine("На 0 делить нельзя, попробуйте повторить действие и ввести другие значения...");
    Thread.Sleep(5000);
    goto start1;
finish3:
    Console.WriteLine("Вы ввели неккоректное значение, попробуйте повторить действие и ввести другое значение");
    Thread.Sleep(5000);
    goto start1;
}