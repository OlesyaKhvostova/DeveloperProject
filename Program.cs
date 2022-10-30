
void InitArrayByStrings(string[] arrayData)
{
    if (arrayData.Length == 10 )
    {
        arrayData[0] = "first";
        arrayData[1] = "as";
        arrayData[2] = "new";
        arrayData[3] = "temp";
        arrayData[4] = "build";
        arrayData[5] = "short";
        arrayData[6] = "I";
        arrayData[7] = "equalizer";
        arrayData[8] = "conversation";
        arrayData[9] = "bye";
    }
}

string[] GetStringsByLength(string[] arrayData, int maxLetter)
{
    int count = 0;
    int[] arrayIndex = new int[arrayData.Length];

    for (int i = 0; i < arrayData.Length; i++)
    {
        if (arrayData[i].Length <= maxLetter)
        {
            arrayIndex[count] = i;
            count++;
        }
    }

    string[] arrayTotal = new string[count];
    for (int i = 0 ; i < count; i++)
    {
        arrayTotal[i] = new string(arrayData[arrayIndex[i]]);
    }
    return arrayTotal;
}

string PrintArray(string[] array)
{
    string outputValue = "[";
    for(int i = 0; i < array.Length; i++)
    {
        outputValue += array[i];
        outputValue +=  ( i + 1 < array.Length ) ? "," : "]";
    }
    return outputValue;
}

void Main()
{
    var data = new string[10];
    InitArrayByStrings(data);
    var total = GetStringsByLength(data, 3);
    Console.WriteLine(PrintArray(data));
    Console.WriteLine(" -> ");
    Console.WriteLine(PrintArray(total));
}

Main();