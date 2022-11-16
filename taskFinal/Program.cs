//  итоги блока, итоговая задача

Console.Clear();


Console.WriteLine("введите пять слов или чего- то, но 5: ");

string[] mass1 = new string[5];   //  создаем массив, который задан пользователем

for (int i = 0; i < mass1.Length; i++)
{
    mass1[i] = Convert.ToString(Console.ReadLine());
}


string[] mass2 = new string[mass1.Length];
void Massiv(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}

Massiv(mass1, mass2);
Console.Write("Результат! => ");
Console.WriteLine("[" + string.Join(",", mass2) + "]");
