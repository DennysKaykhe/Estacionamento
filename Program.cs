const decimal HorasAdicionaisGrandes = 20;
const decimal HorasAdicionaisPequenas = 50;
const decimal DiáriaGrande = 80;
const decimal DiáriaPequena = 50;
const decimal LavagemGrande = 100;
const decimal LavagemPequena = 50;
const double ValetMultiplicar = 0.2;
const decimal PrimeiraHora = 20;

const int TempoDiaria = 5 * 60;
const int TempoTolerancia = 5;
const int MaxTempoPermanencia = 12 * 60;

int perma;
string tamanho;
bool serviçoV, serviçoL;

decimal Pperma = 0;
decimal Pvalet = 0;
decimal Plavagem = 0;
decimal Ptotal = 0;

Console.Clear();

Console.WriteLine("--- Estacionamento ---\n");

Console.Write("Tamanho do veículo (P/G).....: ");
tamanho = Console.ReadLine()!.ToUpper().Trim();

if (tamanho != "P" && tamanho != "G")
{
    Console.WriteLine("Tamanho inválido!");
    return;
}

Console.Write("Tempo de permanência (min)...: ");
perma = Convert.ToInt16(Console.ReadLine());

if (perma <= 0 || perma > MaxTempoPermanencia)
{
    Console.WriteLine("Não aceitamos tempo de permanência acima de 12 horas!");
    return;
}

Console.Write("Serviço de valet (S/N).......: ");
serviçoV = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Serviço de lavagem (S/N).....: ");
serviçoL = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";


if (perma >= TempoDiaria)
{
    if (tamanho == "P")
    {
        Pperma = DiáriaPequena;
    }
    else
    {
        Pperma = DiáriaGrande;
    }
}
else
{
    int horasPermanencia = (int)(perma / 60);
    int minutosRestantes = perma % 60;

    if (minutosRestantes > TempoTolerancia)
    {
        horasPermanencia++;
    }

    Pperma = PrimeiraHora;
    int horasAdicionais = horasPermanencia - 1;

    if (horasAdicionais > 0)
    {
        if (tamanho == "P")
        {
            Pperma += horasAdicionais * HorasAdicionaisPequenas;
        }
        else
        {
            Pperma += horasAdicionais * HorasAdicionaisGrandes;
        }
    }
}

if (serviçoV)
{
    Pvalet = Pperma * Convert.ToDecimal(ValetMultiplicar);
}

if (serviçoL)
{
    if (tamanho == "P")
    {
        Plavagem += LavagemPequena;
    }
    else
    {
        Plavagem += LavagemGrande;
    }
}

Ptotal = Pperma + Pvalet + Plavagem;

Console.WriteLine($"\nEstacionamento..: {Pperma}");
Console.WriteLine($"Valet...........: {Pvalet:C}");
Console.WriteLine($"Lavagem.........: {Plavagem:C}");
Console.WriteLine("--------------------------------\n");
Console.WriteLine($"Total...........: {Ptotal:C}");