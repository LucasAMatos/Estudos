Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);

TestaMediana(amostra);

void TestaArrayInt()
{
    int[] idades = { 30, 40, 17, 21, 18 };

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"idade {i}: {idades[i]}");
        acumulador += idades[i];
    }

    Console.WriteLine($"média da idade = {acumulador / idades.Length}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra:");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    if (arrayDePalavras.Contains(busca))
        Console.WriteLine($"Palavra {busca} encontrada");
    else
        Console.WriteLine($"Palavra não encontrada");
}


void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("array vazio ou nulo");
        return;
    }

    double[] numerosOrdenados = (double[])array.Clone();

    Array.Sort(numerosOrdenados);

    int tam = numerosOrdenados.Length;
    int meio = tam / 2;

    double mediana = (tam % 2 != 0) ? numerosOrdenados[meio] + numerosOrdenados[meio -1] : numerosOrdenados[meio];

    Console.WriteLine($"O valor da mediana é {mediana}");
}
