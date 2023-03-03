using ConcepstPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");
Date date1 = new Date(2022, 05, 25);

try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(2025, 25, 55));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
