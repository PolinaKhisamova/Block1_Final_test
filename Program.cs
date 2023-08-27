string [] DataInput ()
{
    Console.Write("Enter number of lines: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string [] user_array = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter line {i+1}: ");
        user_array[i] = Console.ReadLine()!;
    }
    return user_array;
}

int FindNewArraySize (string [] user_array)
{
    int new_size = 0;
    for (int i= 0; i < user_array.Length; i++)
    {
        if (user_array[i].Length <= 3) new_size ++;
    }
    return new_size;
}

string [] FilterArray (string [] user_array, int size)
{
    string [] filtered_array = new string [size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        while (j < user_array.Length)
        {
            if (user_array[j].Length <= 3)
            {
                filtered_array[i] = user_array[j];
                break;
            }
            else j++;
        }
        j++;
    }
    return filtered_array;
}

void PrintArray (string [] array)
{
    if (array.Length > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ";  ");
        }
        Console.WriteLine("\b\b\b.");
    }
    else
    {
        Console.Write("array is empty.");
    }
}

string [] init_array = DataInput ();
string [] new_array = FilterArray (init_array, FindNewArraySize (init_array));
Console.Write("Your initial array is: ");
PrintArray (init_array);
Console.Write ("Filtered array is: ");
PrintArray (new_array);