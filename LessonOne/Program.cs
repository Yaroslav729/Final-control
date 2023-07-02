Console.Clear();

string[] arrayStart = new string[5] {"126", "2e4r", "nod", "1", "sta"}; 
string[] arrayEnd = new string[arrayStart.Length];

void InputArray(string[] arrayStart, string[] arrayEnd)
{
    int count = 0;
    {
    for (int i = 0; i < arrayStart.Length; i++)
        if(arrayStart[i].Length <= 3)
        {
            arrayEnd[count] = arrayStart[i];
            count++;
        }
    }
}

void PrintArray(string[] arrayEnd)
{
    for (int i = 0; i < arrayEnd.Length; i++)
    {
        Console.Write($"{arrayEnd[i]} ");
    }
    Console.WriteLine();
}
InputArray(arrayStart, arrayEnd);
PrintArray(arrayEnd);
