// See https://aka.ms/new-console-template for more information

while (true)  // Program loop
{

    Console.WriteLine("Enter a string of numbers: ");
    string s_num = Console.ReadLine();
    bool isNumeric = int.TryParse(s_num, out int num);

    if (isNumeric)
    {
        num = int.Parse(new String(s_num.Reverse().ToArray()));  // Reverse doesn't return a string
        Console.WriteLine(num);                                  // Must be typecasted / made into a string
    }
    else
    {
        Console.WriteLine("This string contains characters.");
    }
}