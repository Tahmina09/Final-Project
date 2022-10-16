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