int[] testPoints = { 7, 8, 3, 11, 12 };
double[] doubleTestPoints = new double[testPoints.Length];
double sumTestPoints = 0;
double avaragePoints = 0;

for(int i = 0; i < doubleTestPoints.Length; i++)
{
    doubleTestPoints[i] = testPoints[i];
    sumTestPoints += doubleTestPoints[i];
}


avaragePoints = sumTestPoints / doubleTestPoints.Length;

Console.WriteLine($"Medelpoängen för samtliga poäng är: {avaragePoints}");

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen...");
Console.ReadLine();
