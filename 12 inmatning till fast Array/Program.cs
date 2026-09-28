int[] numbers = new int[5];

Console.WriteLine("Mata in 5 heltal:\n");

for (int i = 0; i < numbers.Length; i++)
{
    while (true)
    {
        Console.Write($"Tal {i + 1}: ");

        if (int.TryParse(Console.ReadLine(), out int value))
        {
            numbers[i] = value;
            break; 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Felaktig inmatning! Skriv ett giltigt heltal.");
            Console.ResetColor();
        }
    }
}

Console.WriteLine("\nDu matade in följande tal:");
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
