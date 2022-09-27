while (2 * 2 == 4)
{
    Console.Clear();
    Console.WriteLine(
    "Консольный калькулятор\n" +
    "1. Сложение 2-х чисел\n" +
    "2. Вычитание 2-х чисел\n" +
    "3. Умножение 2-х чисел\n" +
    "4. Деление двух чисел\n" +
    "5. Возведение числа в пользовательскую степень\n" +
    "6. Вычисление квадратного корня\n" +
    "7. Вычисление 1% от числа\n" +
    "8. Вычисление факториала\n" +
    "9. Выход"
    );
    Console.Write("Ввод типа операции: ");
    string oper = Console.ReadLine();
    string result = "0";
    if (oper == "1")
    {
        Console.WriteLine("Введите первое число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double second_num = Convert.ToDouble(Console.ReadLine());
        result = Convert.ToString(first_num + second_num);
    }
    else if (oper == "2")
    {
        Console.WriteLine("Введите первое число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double second_num = Convert.ToDouble(Console.ReadLine());
        result = Convert.ToString(first_num - second_num);
    }
    else if (oper == "3")
    {
        Console.WriteLine("Введите первое число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double second_num = Convert.ToDouble(Console.ReadLine());
        result = Convert.ToString(first_num * second_num);
    }
    else if (oper == "4")
    {
        Console.WriteLine("Введите первое число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double second_num = Convert.ToDouble(Console.ReadLine());
        if (second_num == 0)
        {
            result = "Ошибка: нельзя делить на 0";
        }
        else
        {
            result = Convert.ToString(first_num / second_num);
        }
    }
    else if (oper == "5")
    {
        Console.Write("Введите первое число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double second_num = Convert.ToDouble(Console.ReadLine());
        double raw_result = 1;
        for (int i = 1; i <= second_num; i++)
        {
            raw_result *= first_num;
        }
        result = Convert.ToString(raw_result);
    }
    else if (oper == "6")
    {
        Console.Write("Введите число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        if (first_num < 0)
        {
            result = "Ошибка: нельзя считать корень отрицательного числа";
        }
        else
        {
            result = Convert.ToString(Math.Sqrt(first_num));
        }
    }
    else if (oper == "7")
    {
        Console.Write("Введите число: ");
        double first_num = Convert.ToDouble(Console.ReadLine());
        result = Convert.ToString(first_num / 100);
    }
    else if (oper == "8")
    {
        Console.Write("Введите число: ");
        int first_num = Convert.ToInt32(Console.ReadLine());
        if (first_num < 1)
        {
            result = "Ошибка: нельзя вычислять факториал отрицательного числа";
        }
        else
        {
            int raw_result = 1;
            for (int i = 1; i <= first_num; i++)
            {
                raw_result *= i;
            }
            result = Convert.ToString(raw_result);
        }
    }
    else if (oper == "9")
    {
        Console.Write("Press any key to exit :D");
        Console.ReadKey();
        Environment.Exit(0);
    }
    else
    {
        result = "Неверная операция";
    }
    Console.WriteLine("\nРезультат работы программы: " + result + "\nНажмите любую клавишу для продолжения");
    Console.ReadKey();
};