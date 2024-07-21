//Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0 || i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}