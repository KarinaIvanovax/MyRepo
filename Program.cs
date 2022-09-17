/*try
{
    //деление двух любых чисел
    Console.WriteLine("Задача 1. Поделить два числа");
    Console.Write("Введите число ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите число ");
    double b = double.Parse(Console.ReadLine());
    double c = a / b;

    Console.WriteLine($"Деление={c}");
}
catch(OverflowException caught)
{
    Console.WriteLine(caught);
}
catch(DivideByZeroException caught)
{
    Console.WriteLine(caught);
}
finally
{
    Console.WriteLine("Блок try-catch завершен");
}*/



/*Console.Write("Введите букву от а до я: ");
{
    //вывод на экран букв в алфавитном порядке
    string x = (Console.ReadLine());
    if (x == "а")
        Console.Write($"б");
    else if (x == "б")
        Console.Write($"в");
    else if (x == "в")
        Console.Write($"г");
    else if (x == "г")
        Console.Write($"д");
    else if (x == "д")
        Console.Write($"е");
    else if (x == "е")
        Console.Write($"ж");
    else if (x == "ж")
        Console.Write($"з");
    else if (x == "з")
        Console.Write($"и");
    else if (x == "и")
        Console.Write($"й");
    else if (x == "й")
        Console.Write($"к");
    else if (x == "к")
        Console.Write($"л");
    else if (x == "л")
        Console.Write($"м");
    else if (x == "м")
        Console.Write($"н");
    else if (x == "н")
        Console.Write($"о");
    else if (x == "о")
        Console.Write($"п");
    else if (x == "п")
        Console.Write($"р");
    else if (x == "р")
        Console.Write($"с");
    else if (x == "с")
        Console.Write($"т");
    else if (x == "т")
        Console.Write($"у");
    else if (x == "у")
        Console.Write($"ф");
    else if (x == "ф")
        Console.Write($"х");
    else if (x == "х")
        Console.Write($"ц");
    else if (x == "ц")
        Console.Write($"ч");
    else if (x == "ч")
        Console.Write($"ш");
    else if (x == "ш")
        Console.Write($"щ");
    else if (x == "щ")
        Console.Write($"ъ");
    else if (x == "ъ")
        Console.Write($"ы");
    else if (x == "ы")
        Console.Write($"ь");
    else if (x == "ь")
        Console.Write($"э");
    else if (x == "э")
        Console.Write($"ю");
    else if (x == "ю")
        Console.Write($"я");
    else if (x == "я")
        Console.Write($"Конец");
}*/
/*using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Решение квадратного уравнения");
//ввод данных
Console.Write("a = ");
var a = double.Parse(Console.ReadLine());
Console.Write("b = ");
var b = double.Parse(Console.ReadLine());
Console.Write("c = ");
var c = double.Parse(Console.ReadLine());

//дискриминант
double x1, x2;
var discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("Уравнение не имеет корней");
}
else if (discriminant == 0) //уравнение будет иметь два одинаковых корня
{
    x1 = -b / (2 * a);
    x2 = x1;
}
else if (discriminant > 0) //уравнение будет иметь два разных корня
{
    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
}
//вывод корней уравнения
Console.WriteLine($"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}; x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}");*/

