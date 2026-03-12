Console.WriteLine("Enter integers:");
int? input1 = int.Parse(Console.ReadLine());
int? input2 = int.Parse(Console.ReadLine());
int[] numbers = { 1, 2, 3, 4, 5 };

if (input1 == null && input2 == null)
{
    Console.WriteLine("Please enter an integers");
    return;
}

Console.WriteLine($"Average: {(input1 + input2)/2}");
Console.WriteLine($"Sum: {input1 + input2}: ");
Console.WriteLine($"Subtraction: {input1 - input2}: ");
Console.WriteLine($"Multiplication: {input1 * input2}: ");
Console.WriteLine(CalculateAverage(numbers));
Console.WriteLine(CalculateMax(numbers));

int CalculateAverage(int[] values)
{
    return values.Sum() / values.Length;
}

int CalculateMax(int[] values) {
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");

    return values.Max();
}

int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");
    
    return values.Min();
}