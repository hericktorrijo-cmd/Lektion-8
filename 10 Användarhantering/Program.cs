List<string> userNames = new List<string>()
{
    "botten",
    "smiley",
    "jokern",
    "rolixen",
    "mago"
};


Console.Write("Skriv ett namn du vill ta bort från listan om den finns med i listan: ");
string userChoice = Console.ReadLine().Trim().ToLower();

bool removed = userNames.Remove(userChoice);

if(removed)
{
    Console.WriteLine("Du lyckades ta bort användarnamnet från listan, så här ser listan ut nu: \n");
    Console.WriteLine("_________________________________________________________________________\n");
}
else
{
    Console.WriteLine("Hittade inget sådant namn, så här ser listan ut: \n");
    Console.WriteLine("_______________________________________________\n");
}

foreach(string name in userNames)
{
    Console.WriteLine(name);
}
Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
