using System.Runtime.Intrinsics.X86;
using System;
ExercicioAdivinhacao();

void ExercicioNota()
{
    // Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
    int notaMedia = 0;
    Console.Write("Digite o valor da média do aluno:");
    notaMedia = int.Parse(Console.ReadLine());

    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
}

void ExercicioLista()
{
    //Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
    List<string> Linguagens = new List<string>(){
    "C#",
    "Java",
    "Javastript"
};

    //Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
    Console.WriteLine(Linguagens.First());

    //Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
    Console.Write($"Digite uma posição na lista de 1 a {Linguagens.Count}");

    int opcao = int.Parse(Console.ReadLine());

    if (opcao < 1 || opcao > Linguagens.Count)
    {
        Console.WriteLine("Opção inválida");
        return;
    }

    Console.WriteLine(Linguagens[opcao - 1]);
}

void ExercicioAdivinhacao()
{
    int randomico = new Random().Next(1, 100);
    Console.WriteLine("Pensei em um número entre 1 e 100 você consegue acertar?");

    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado < 1 || numeroDigitado > 100)
    {
        Console.WriteLine("Você não sabe brincar!");
        return;
    }

    if (numeroDigitado > randomico)
    {
        Console.WriteLine("Chutou Alto Demais! Deveria tentar ser astronauta!");
        return;
    }

    if (numeroDigitado < randomico)
    {
        Console.WriteLine("Nossa você me dá tão pouco assim??");
        return;
    }

    Console.WriteLine("Como você sabia?");
    return;
}