Console.Clear();

Console.WriteLine("Enter some words or symbols. ");

string [] Base = FillArray();

string [] FillArray()
{
    string [] array = new string [3];
    for(int n=0; n<array.Length; n++)
    {
        Console.Write($"Enter {n+1} word: ");
        array[n] = Console.ReadLine();
        Console.WriteLine();
    }
    return array;
}

string [] check(string [] array)
{
    int count = 0;
    string [] less = new string [array.Length];
    for(int n=0; n<array.Length;n++)
    {
        if(array[n].Length <= 3)
        {
            less [count] = array[n];
            count++;
        }
    }
    return less;
}

string [] result = check(Base);

Console.WriteLine("Base string equals: " + '[' + string.Join(", ", Base) + ']' + ".");
Console.WriteLine("Words including less than four symbols: " + string.Join(" ", result) + ".");
Console.WriteLine(String.Join(" ", (result)));