try
{
    Console.WriteLine("Введите целое число ");
    int x=Convert.ToInt32 (Console.ReadLine());
    int y=x%2;
    if (y == 0)
    {
        Console.WriteLine("является четным числом ");
    }
    else Console.WriteLine("не является четным числом ");

}
catch
{
Console.WriteLine("Необходимо ввести целое число цифрами");
}
