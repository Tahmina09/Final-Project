Console. Clear ();
Console.WriteLine("Сколько строк хотите ввести?");
int count = Convert. ToInt32 (Console. ReadLine ());
string [] array = new string [count]; 
string str = String. Empty;
Console.WriteLine();

for(int i=0; i<count; i++)
{
    Console.WriteLine("Введите строку: ");
    str = Console.ReadLine();
    array[i] = str;
}

string [] newArray = new string [count];
for(int i=0; i<array.Length; i++)
{
    if(array[i].Length<=3)
    {
        newArray[i]=array[i];
    }
}

void PrintArray(string [] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);