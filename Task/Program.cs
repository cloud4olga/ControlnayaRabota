// string[] array1 = {"Russia", "Denmark", "Kazan"};                // → []
string[] array1 = {"Hello", "2", "world", ":-)"};                   // → [“2”, “:-)”]
// string[] array1 = {"1234", "1567", "-2", "computer science"};    // [“-2”]

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
    {
    count = count + 1;
    }
} 

string[] array2 = new string [count]; 

void FillSecondArray(string[] array1, string[] array2)
{
int n = 0;
for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[n] = array1[i];
        n++;
        }
    }
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
        {
            Console.Write("[");
            for (int i = 0; i < (array.Length-1); i++)
            {   
                Console.Write($"{array[i]}" + ", ");
            }
            for (int i = array.Length-1; i < array.Length; i++)
            {   
                Console.Write($"{array[i]}");
            }
            Console.Write("]");
            Console.WriteLine();
        }
}

FillSecondArray(array1, array2);
PrintArray(array2);