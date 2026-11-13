Console.WriteLine("Informe a quantidade de notas e depois a quantidade de materia!");
int materia = int.Parse(Console.ReadLine());
int nota = int.Parse(Console.ReadLine());

string[,] matriz = new string[nota + 1, materia + 1];

for (int i = 0; i < nota; i++)
{
    for (int j = 0; j < materia; j++)
    {
        if (i == 0)
        {
            matriz[i, j+1] = $"Nota{j + 1 }";
        }
        if (j == 0) 
        {
            Console.WriteLine("Informe nome das materias!");
            matriz[i+1, j] = Console.ReadLine();
        }

    }
}

for (int i = 0; i < nota; i++)
{
    for (int j = 0; j < materia; j++)
    {
        if (i == 1)
        {
            Console.WriteLine($"Informe a nota da {matriz[1,0]}");
            matriz[i, j + 1] = Console.ReadLine();
        }
        if (j == 1)
        {
            Console.WriteLine($"Informe a nota da {matriz[2, 0]}");
            matriz[i+1, j] = Console.ReadLine();
        }
    }
}

Console.WriteLine();

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}