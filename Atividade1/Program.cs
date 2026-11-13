Console.WriteLine("Informe um valor para criar uma matriz quadrada!");
int matrizquadrada = int.Parse(Console.ReadLine());

int[,] matriz = new int[matrizquadrada,matrizquadrada];

for(int i = 0; i < matrizquadrada; i++)
{
    for(int j = 0; j < matrizquadrada; j++)
    {
        Console.WriteLine($"Informe os valores da posição {i},{j}");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
for(int i = 0;i < matriz.GetLength(0); i++)
{
    for (int j = 0;j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int somalinha = 0, somacoluna = 0;
for (int i = 0; i < matriz.GetLength(0); i++)
{
    somalinha = 0;
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        somalinha += matriz[i,j];
    }
    Console.WriteLine($"Soma da Linha {i + 1}: {somalinha}");
}

for (int i = 0; i < matriz.GetLength(1); i++)
{
    somacoluna = 0;
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
      somacoluna += matriz[j, i];
    }
    Console.WriteLine($"Soma da Coluna {i + 1}: {somacoluna}");
}
Console.WriteLine();

int somadiagonalprincipal = 0, somadiagonalinversa = 0;

for (int i = 0;i < matrizquadrada; i++)
{
    somadiagonalprincipal += matriz[i, i];
    somadiagonalinversa += matriz[i, matrizquadrada -1 - i];
}
Console.WriteLine($" Soma diagonal principal {somadiagonalprincipal}");
Console.WriteLine($" Soma diagonal inversa {somadiagonalinversa}");