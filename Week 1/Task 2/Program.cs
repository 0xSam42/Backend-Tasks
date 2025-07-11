// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array Multiplier");

while (true)  // Program Loop
{

    Console.WriteLine("Enter the size of the array: ");
    string input = Console.ReadLine();
    int size = int.Parse(input);

    int[] array = new int[size];
    Console.WriteLine("Enter array elements: ");
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    int product = 1;
    bool nonzero = false;

    for (int i = 0; i < size; i++)
    {
        if (array[i] == 0) continue;

        nonzero = true;                   // flag
        product = product * array[i];

    }

    if (nonzero)
    {
        Console.WriteLine("The product of all nonzero elements is " + product);
        Console.WriteLine("----------------------------------------------------");
    }
    else
    {
        Console.WriteLine("The array is empty");
        Console.WriteLine("-----------------------------------------------------");
    }

}