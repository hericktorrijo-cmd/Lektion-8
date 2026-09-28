string[] names = { "erik", "kim", "johan", "kim", "johan", "pedro", "pascal" };
int count = 0;

Console.WriteLine("Namn som förekommer mer än 1 gång: ");

for (int i  = 0; i < names.Length; i++)
{
    string current = names[i];
    

    for (int j = 0; j < names.Length; j++)
    {
        if (names[j] == current)
        {
            count++;
        }
    }
    if (count > 1)
    {
    
        bool exists = false;

        for (int k = 0; k < i; k++)
        {
            if (names[k] == current)
            {
                exists = true;
                break;
            }
        }

        if (exists)
        {
            Console.WriteLine(current);
        }
    }

}

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
