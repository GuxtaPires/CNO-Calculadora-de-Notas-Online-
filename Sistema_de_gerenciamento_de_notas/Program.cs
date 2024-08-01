using System;
using System.Runtime.Serialization;

Console.WriteLine("---------------------------CNO---------------------------");
Console.WriteLine("Olá, seja bem vindo ao CNO (Calculadora de Notas Online)");
Console.WriteLine("Antes de tudo, digite o número com base na base de calculo da sua nota:");
Console.WriteLine("1 - Cáclulo de média simples");
Console.WriteLine("2 - Cálculo de média ponderada");

int escolha = Int32.Parse(Console.ReadLine());

switch (escolha){
    case 1:
        Console.WriteLine("Informe a média de sua instituição de ensino");
        int notaCorte = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Agora, informe quantas notas você possui:");
        int quantNotas = Int32.Parse(Console.ReadLine());

        decimal somanotas = 0;

        for (int i = 0; i < quantNotas; i++){
            Console.WriteLine("Informe a " + (i+1) + "º nota:");
            decimal nota = decimal.Parse(Console.ReadLine());
            somanotas = somanotas + nota;
        }
        decimal media = somanotas / quantNotas;

        Console.WriteLine("Sua média será: " + media);

        if (media >= 6)
        {
            Console.WriteLine("Parabens, você foi aprovado!");
            Console.WriteLine("---------------------------CNO---------------------------");
        }
        else
        {
            Console.WriteLine("Infelizmente você terá que ir para a recuperação... Boa sorte");
            Console.WriteLine("---------------------------CNO---------------------------");
        }
        break;
    case 2:
        Console.WriteLine("Informe a média de sua instituição de ensino");
        notaCorte = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Agora, informe quantas notas você possui:");
        quantNotas = Int32.Parse(Console.ReadLine());

        somanotas = 0;
        int somaPesos = 0;

        for (int i = 0; i < quantNotas; i++)
        {
            Console.WriteLine("Informe a " + (i + 1) + "º nota:");
            decimal nota = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso dessa nota:");
            int peso = Int32.Parse(Console.ReadLine());
            somaPesos = somaPesos + peso;
            nota = nota * peso;
            somanotas = somanotas + nota;
        }

        media = somanotas / somaPesos;

        Console.WriteLine("Sua média final é: " + media);

        if (media >= 6)
        {
            Console.WriteLine("Parabens, você foi aprovado!");
            Console.WriteLine("---------------------------CNO---------------------------");
        }
        else
        {
            Console.WriteLine("Infelizmente você terá que ir para a recuperação... Boa sorte");
            Console.WriteLine("---------------------------CNO---------------------------");
        }
        break;
}
Console.ReadKey();