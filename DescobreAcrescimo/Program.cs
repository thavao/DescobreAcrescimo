double valorAtual, valorNovo, valorDeAcrescimo;

Console.Write("Digite o valor atual: ");
valorAtual = double.Parse(Console.ReadLine());

Console.Write("Digite o valor novo: ");
valorNovo = double.Parse(Console.ReadLine());

if (valorNovo > valorAtual)
{
    valorDeAcrescimo = valorNovo - valorAtual;
    Console.WriteLine("Valor de acréscimo foi: " + valorDeAcrescimo);
}
else
    Console.WriteLine("Não houve acréscimo...");

Console.WriteLine("Pressione Enter para encerrar...");

Console.ReadLine();

