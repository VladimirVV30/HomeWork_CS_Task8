try
{
    Console.WriteLine("Введите целое число ");
    int N=Convert.ToInt32 (Console.ReadLine());
    
    int i=2;
    while (i<=N)
    {
        Console.Write (i+", ");
        i = i+2;
    }

}
catch
{
Console.WriteLine("Необходимо ввести целое число цифрами");
}
