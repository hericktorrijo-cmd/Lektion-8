List<string> shoppingList = new List<string>();


while (true)
{
    Console.Write("Produkt(skriv (AVSLUTA) när du är klar): ");
    string input = Console.ReadLine().ToLower();

    if(input == "avsluta")
    {
        break;
    }
    shoppingList.Add(input);

}

Console.WriteLine("\nInköpslista: ");
foreach(string item in shoppingList)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();

