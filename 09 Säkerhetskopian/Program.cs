string[] firstArray = { "IP=195.176", "IP=196.177", "IP=197.178", "IP=198.179", "IP=199.180" };
string[] secondArray = new string[firstArray.Length];

Array.Copy(firstArray, secondArray, firstArray.Length);

firstArray[0] = "IP-000.000";

Console.WriteLine($"Första index på första arrayen innehåll: {firstArray[0]}");
Console.WriteLine($"Andra index på andra arrayen innehåll: {secondArray[0]}");

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
