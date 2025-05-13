string tamanho, valet, lavagem;
int tempo, horas, horasAdicionais;
double precoEstacionamento, precoValet, precoLavagem, total;

Console.Clear();
Console.WriteLine("--- Estacionamento ---");

Console.Write("Tamanho do veículo (P/G).....: ");
tamanho = Console.ReadLine().ToUpper();

if (tamanho != "P" && tamanho != "G")
{
    Console.WriteLine("Tamanho inválido.");
    return;
}

 Console.Write("Tempo de permanência (min)...: ");
 tempo = Convert.ToInt32(Console.ReadLine());
 
 if (tempo <= 0 && tempo > 720)
{
 Console.WriteLine("Tempo inválido. Deve ser entre 1 e 720 minutos.");
 return;
}

Console.Write("Serviço de valet (S/N).......: ");
         valet = Console.ReadLine().ToUpper();

Console.Write("Serviço de lavagem (S/N).....: ");
        lavagem = Console.ReadLine().ToUpper();

precoEstacionamento = 0;
precoValet = 0;
precoLavagem = 0;

if (tempo <= 65 )
{
    precoEstacionamento = 20;
}
else 
{
    horas = (int)Math.Ceiling((tempo - 5) / 60.0);
if (horas >= 5)
            {
                if (tamanho == "G")
                {
                  precoEstacionamento = 80;
                }
                else
                {
                  precoEstacionamento = 50;
                }
            }
            else
            {
                precoEstacionamento = 20; 
                horasAdicionais = horas - 1;
                if (tamanho == "G")
                {
                  precoEstacionamento += horasAdicionais * 20;
                }
                else
                {
                  precoEstacionamento += horasAdicionais * 10;
                }
            }
        }

 if (valet == "S")
        {
            precoValet = precoEstacionamento * 0.20;
        }

        if (lavagem == "S")
        {
           if (tamanho == "G")
            {
              precoLavagem = 100;
            }
           else
           {
             precoLavagem = 50;
           }
        }

         total = precoEstacionamento + precoValet + precoLavagem;

        Console.WriteLine();
        Console.WriteLine($"Estacionamento..: {precoEstacionamento,10:C2}");
        Console.WriteLine($"Valet...........: {precoValet,10:C2}");
        Console.WriteLine($"Lavagem.........: {precoLavagem,10:C2}");
        Console.WriteLine($"--------------------------------"); 
        Console.WriteLine($"Total...........: {total,10:C2}");