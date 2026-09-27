Console.Write("Ange storleken på vektorn: ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

for(int i = 0; i < n; i++)
{
    Console.Write($"Element nummer {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

bool isSymmetric = true; 
for (int i = 0;i < array.Length/2; i++)
{
    if (array[i] != array[n - i -1])
    {
        isSymmetric = false;
        break;
    }
}