// запрашиваем у пользователя число
Console.Write("Input number: ");

// создаем переменную number и сохраняем в нее значение, введение из консоли
int number = Convert.ToInt32(Console.ReadLine());

// объявляем переменую q и сохраняем в нее квадрат числа number
int q = number * number;

// вводим значения переменных number и q
Console.WriteLine(number + " -> " + q);