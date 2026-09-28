string[] cities = { "stockholm", "valparaiso", "london", "los Angeles" };

while(true)
{
    Console.Write("Skriv en stad så ska vi se om den finns med i listan: ");
    string input = Console.ReadLine().ToLower();
    bool hittad = false;

    for(int i = 0; i < cities.Length; i++)
    {
        if(input == cities[i])
        {
            Console.WriteLine($"Ditt val {input} finns med i listan på plats nummer {i + 1}");
            hittad = true;
            break;
        }
    }
   

    if(hittad)
    {
        break;
    }
    else
    {
        Console.WriteLine("Finns inte försök igen!");
    }
   

}


Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
