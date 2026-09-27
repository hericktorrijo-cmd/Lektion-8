string[] items = { "Ananas", "Tonfisk", "Salt", "Mjölk" };

for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"{i}: {items[i]}");
}

Console.WriteLine("__________________\n");
//alternativt
for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"{i + 1}: {items[i]}");
}

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
