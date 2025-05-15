double perma, total, HorasAdicionais, ValorDasHorasAdcionais, Diária, Lavagem, valet;
string tamanho, serviçoV, serviçoL;

Console.Clear();

Console.WriteLine("--- Estacionamento ---\n");

Console.Write("Tamanho do veículo (P/G).....: ");
tamanho = Console.ReadLine()!.ToUpper().Trim();

if (tamanho != "P" && tamanho != "G");
{
    Console.WriteLine("Tamanho inválido! Por favor aperte qualquer tecla para voltar a questão.");
    Console.ReadKey();
    return;
}
    if (tamanho == "P")
    {
        HorasAdicionais = 0.16666666666;
        Diária = 50;
        Lavagem = 50;
    }
    if (tamanho == "G")
    {
        HorasAdicionais = 0.33333333333;
        Diária = 80;
        Lavagem = 100;
    }


Console.Write("Tempo de permanência (min)...: ");
perma = Convert.ToDouble(Console.ReadLine());

if (perma >= 720)
{
    Console.WriteLine("Não aceitamos tempo de permanência acima de 12 horas! Por favor aperte qualquer tecla para voltar a questão.");
    Console.ReadKey();
    return;
}

Console.Write("Serviço de valet (S/N).......: ");
serviçoV = Console.ReadLine()!.ToUpper().Trim();

if (serviçoV != "S" && serviçoV != "N");
    {
        Console.WriteLine("Resposta inválida! Por favor aperte qualquer tecla para voltar a questão.");
        Console.ReadKey();
        return;
    }
if (serviçoV == "S")
    {
        valet = 1.20;
    }
    else if (serviçoV == "N")
    {
        valet = 0;
    }

Console.Write("Serviço de lavagem (S/N).....: ");
serviçoL = Console.ReadLine()!.ToUpper().Trim();

if (serviçoL != "S" && serviçoL != "N")
{
    Console.WriteLine("Resposta inválida! Por favor aperte qualquer tecla para voltar a questão.");
    Console.ReadKey();
    return;
}
    else if (serviçoL == "S")
    {
        // Tudo segue normalmente;
    }
        else if (serviçoL == "N")
    {
        Lavagem = 0;
    }

double EstacionamentoFinal;

if (perma <= 60)
{
    EstacionamentoFinal = 20;
}
    else if (perma > 60 && perma < 300)
    {
    ValorDasHorasAdcionais = perma * HorasAdicionais;
    }
    else if (perma >= 300)
    {
        EstacionamentoFinal = Diária;
    }

EstacionamentoFinal = EstacionamentoFinal * valet;

Console.Write($"\nEstacionamento..: R$ {EstacionamentoFinal}");

valet = EstacionamentoFinal * 0.20;

Console.Write($"Valet...........: R$ {valet}");

Console.Write($"Lavagem.........: R$ {Lavagem}");

Console.WriteLine("--------------------------------\n");

total = EstacionamentoFinal + Lavagem;

Console.WriteLine($"Total...........: R$ {total}");