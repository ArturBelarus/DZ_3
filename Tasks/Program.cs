// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число: {number} - не палиндром");
    }

}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"не правильное число");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);

Console.WriteLine("Введите координаты точки B");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

if (!isParsedXA || !isParsedYA || !isParsedZA || !isParsedXB || !isParsedYB || !isParsedZB)
{
    Console.WriteLine("Не правильно введены координаты");
    return;
}

double distanceDot = Distance3D(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками {distanceDot}");


double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dis;
}

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN || n <= 0)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}

int[] arrayCubes = TableOfCubes(n);
PrintArray(arrayCubes);

int[] TableOfCubes(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}