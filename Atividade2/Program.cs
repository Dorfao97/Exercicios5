const int COLUNAS = 7;
int materia = 0, cont = 0;

Console.WriteLine("Informe a quantidade de materia!");
materia = int.Parse(Console.ReadLine());

string[,] matriz = new string[materia, COLUNAS];

void CadastraMaterias()
{
    do
    {
        Console.Write("Informe a materia desejada: ");
        matriz[cont, 0] = Console.ReadLine();
        cont++;
    } while (cont < materia);
}

float GerarNota()
{
    /*
     double d = Random.Shared.NextDouble() * 10;
     d = Math.Round(d,2);
     float f = float.Parse(d);
     return f;
     */

    return (float)Math.Round((Random.Shared.NextDouble()) * 10, 2);
}

void PopularBoletim()
{
    for (int linha = 0; linha < materia; linha++)
    {
        for (int coluna = 1; coluna < 5; coluna++)
        {
            matriz[linha, coluna] = GerarNota().ToString();
        }
    }
}

void GerarMedia(string[,] matriz)
{
    for (int linha = 0; linha < materia; linha++)
    {
        float somatoria = 0;
        int coluna = 1;

        for (; coluna < 5; coluna++)
        {
            somatoria = somatoria + (float.Parse(matriz[linha,coluna]));
        }
        matriz[linha,coluna] = Math.Round((somatoria / 4),2).ToString();
    }

}

void DefinirSituacao(string[,] matriz)
{
    for(int linha = 0;linha < materia; linha++)
    {
        float media = float.Parse(matriz[linha, 5]);
        if (media >= 7)
            matriz[linha, 6] = "Aprovado!";
        else if (media >= 5)
        {
            matriz[linha, 6] = "Recuperação!";
        }
        else
        {
            matriz[linha, 6] = "Reprovado!";
        }
    }
}

void ExibirBoletim(string[,] matriz)
{
    Console.WriteLine("Matéria".PadRight(15) 
        + "1º Bi".PadRight(15) 
        + "2º Bi".PadRight(15) 
        + "3º Bi".PadRight(15) 
        + "4º Bi".PadRight(15) 
        + "Média".PadRight(15) 
        + "Situação".PadRight(15));

    for (int linha = 0; linha < materia; linha++)
    {
        for (int coluna = 0; coluna < COLUNAS; coluna++)
        {
            Console.Write($"{matriz[linha,coluna]}".PadRight(15));
        }
        Console.WriteLine();
    }
}

CadastraMaterias();
PopularBoletim();
GerarMedia(matriz);
DefinirSituacao(matriz);
ExibirBoletim(matriz);
