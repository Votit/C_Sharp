Console.WriteLine("Enter array length: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) 
    {
        Console.Write($"{arr[i]} ");
        count++;
    }
}

Console.WriteLine(count);