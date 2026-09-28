//Console.Write("Ange storleken på vektorn: ");
//int n = int.Parse(Console.ReadLine());

//int[] array = new int[n];

//for(int i = 0; i < n; i++)
//{
//    Console.Write($"Element nummer {i}: ");
//    array[i] = int.Parse(Console.ReadLine());
//}

//bool isSymmetric = true; 
//for (int i = 0;i < array.Length/2; i++)
//{
//    if (array[i] != array[n - i -1])
//    {
//        isSymmetric = false;
//        break;
//    }
//}

//______________________________________________________
//LISTOR

//List<int> intList = new List<int>();

//for(int i = 0; i < 5; i++)
//{
//    intList.Add(i);
//}
//foreach (int i in intList)
//{
//    Console.Write(i + 1);
//}

//List<string> names = ["Herick", "Torrijo"];

//foreach(string name in names)
//{
//    Console.WriteLine(name);
//}

//using System.Globalization;

//List<int> numbers = new List<int>();
//List<string> names = new List<string>(5);

//string[] animals = { "Ko", "får", "krokodil" };
//List<string> animalsList = new List<string>(animals);

//numbers.Add(10);
//numbers.Add(100);
//numbers.Add(1000);
//names.Add("Astrid");
//names.Add("Maylen");
//animalsList.Add("Hund");
//foreach(string animal in animalsList)
//{
//    Console.WriteLine(animal);
//}
//for(int i  = 0; i < animalsList.Count;  i++)
//{
//    Console.WriteLine(animalsList[i]);
//}
//Console.WriteLine(animalsList.Capacity);
List<int> firstList = new List<int>();
for(int i = 0; i <= 3;  i++)
{
    firstList.Add(i);
}

Console.WriteLine($"Första add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Första count: Antal Element: {firstList.Count}");

firstList.Add(4);
firstList.Add(5);

Console.WriteLine($"Andra add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Andra count: Antal Element: {firstList.Count}");

firstList.Add(6);
firstList.Add(7);
firstList.Add(8);
firstList.Add(9);
Console.WriteLine($"Tredje add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Tredje count: Antal Element: {firstList.Count}");

firstList.Add(10);
firstList.Add(11);
Console.WriteLine($"Fjärde add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Fjärde count: Antal Element: {firstList.Count}");

firstList.Add(12);
Console.WriteLine($"Sista add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Sista count: Antal Element: {firstList.Count}");

firstList.Remove(0);
firstList.Remove(1000);

void PrintIntList(List<int> list)
{
    foreach(var item in list)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

PrintIntList(firstList);

firstList.RemoveAt(4);//tar bort index
PrintIntList(firstList);

firstList.RemoveRange(5, 3); //första är vilket index den ska börja på och andra siffran är antal element den ska ta bort
PrintIntList(firstList);
int help = 3;
firstList.RemoveAt(help);

Console.WriteLine("TÖM LISTA MED CLEAR");
firstList.Clear(); //TÖMMER HELA LISTAN
PrintIntList(firstList);
Console.WriteLine($"Efter Clear add: Kapacitet: {firstList.Capacity}");
Console.WriteLine($"Efter Clear: Antal Element: {firstList.Count}");