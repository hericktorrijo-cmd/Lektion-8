double[] weatherTemeperatures = {25.3, 28.5, 20.5, 19.5, 10.7, 31.5, 3.65};

double highetsTemeperature = weatherTemeperatures[0];

for(int i = 1; i < weatherTemeperatures.Length; i++)
{
    if (weatherTemeperatures[i] > highetsTemeperature)
    {
        highetsTemeperature = weatherTemeperatures[i];
    }
}

Console.WriteLine($"Den högsta temeperaturen i listan är: {highetsTemeperature}");


Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
