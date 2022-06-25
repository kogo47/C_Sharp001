//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да

// вводим первое число
Console.Write("Input first number: ");

// сохраняем значение в переменную
int number_1 = Convert.ToInt32(Console.ReadLine());

// вводим второе число и сохраняем значение в переменную
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

// объявляю переменную q, в которую сохраняю квадрат второго введенного числа
int q = number_2 * number_2;

// сравниваем значение первой переменной со значением переменной q
 if (number_1 == q)
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " ->  yes");
 else
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> no");
