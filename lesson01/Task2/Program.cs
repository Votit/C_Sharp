int [] numbers = new int [5];

for (int i = 0; i < numbers.Length; i++) {
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++) {
    Console.Write(numbers[i] + " ");
} 