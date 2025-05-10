double perma, esta, valet, lavagem, total;
string tamanho, serviçoV, serviçoL;

Console.Clear();

Console.WriteLine("--- Estacionamento ---\n");

Console.Write("Tamanho do veículo (P/G).....: ");
tamanho = Console.ReadLine()!.ToUpper().Trim();

if (tamanho != "p" && tamanho != "G");
{
    Console.WriteLine("Tamanho inválido! Por favor escreva qualquer tecla para voltar a questão.");
    Console.ReadKey();
    return;
}

Console.Write("Tempo de permanência (min)...: ");
perma = Convert.ToDouble(Console.ReadLine());

Console.Write("Serviço de valet (S/N).......: ");
Console.ReadLine();

if ();

Console.Write("Serviço de lavagem (S/N).....: ");
Console.ReadLine();

Console.Write($"\nEstacionamento..: {esta}");

Console.Write($"Valet...........: {valet}");

Console.Write($"Lavagem.........: {lavagem}");

Console.WriteLine("--------------------------------\n");

Console.WriteLine($"Total...........: {total}");