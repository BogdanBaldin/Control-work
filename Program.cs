Console.Write("Сколько элементов Вы хотите ввести? ");
size int = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j ++)
{
    
 if (arrayStrings[j].Длина <= len)
    {
 arrayFinal[pos] = arrayStrings[j];
 pos++;
    }
}

Console.WriteLine();
printArray(arrayFinal);

