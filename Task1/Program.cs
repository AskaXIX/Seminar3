string? str = System.Console.ReadLine();

if (str![0] == str![4] && str![1] == str![3] && str![2] != str![0] && str![2] != str![1])
{
    System.Console.WriteLine($"{str} - correct!");
}
else
{
    System.Console.WriteLine($"{str} - incorrect!");
}