//  итоги блока, итоговая задача

Console.Clear();


Console.WriteLine("введите пять слов или чего- то, но 5: ");

string[] mass1 = new string[5];   //  создаем массив, который задан пользователем
int n = 0;

for (int i = 0; i < mass1.Length; i++)
{
    mass1[i] = Convert.ToString(Console.ReadLine());
    if(mass1[i].Length <= 3) n++;
}
string[] mass2 = new string[n];


void Massiv(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

Massiv(mass1, mass2);
Console.Write("Результат! => ");
Console.WriteLine("[" + string.Join(",", mass2) + "]");