Console.WriteLine($"Задайте длинну массива!");
int length = Convert.ToInt32(Console.ReadLine());

 string [] FillArray (int size)
 {
    string [] array = new string [size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Введите {i} значение:");
    array[i] = Console.ReadLine();
  }
  return array;
}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

int FindValues (string [] array)
{
    int count = 0;
    string arrayValue = "0";
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) count++;
    }
    return count;
}

string [] ResultArray (int size, string [] array)
{
    string [] NewArray = new string [size];
    string arrayValue = "0";
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) 
        {
            NewArray[k] = array[i]; 
            k++;
        }
    }
    return NewArray;
}

string [] ourArray = FillArray(length);
PrintArray(ourArray);
int resultValue = FindValues(ourArray);
string [] resultArray = ResultArray(resultValue, ourArray);
PrintArray(resultArray);
