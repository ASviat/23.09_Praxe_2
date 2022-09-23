bool isSquareNumbers()
{
    Console.WriteLine("Введите первое число: ");
    int n1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int n2=Convert.ToInt32(Console.ReadLine());

    return (n1%n2==0 || n2%n1==0);
}

if (isSquareNumbers()) Console.WriteLine("Да");
else Console.WriteLine("Нэт");


