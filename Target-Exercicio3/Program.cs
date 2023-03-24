double[] faturamento = new double[30];

faturamento[0] = 22174.1664;
faturamento[1] = 24537.6698;
faturamento[2] = 26139.6134;
faturamento[3] = 0.0;
faturamento[4] = 0.0;
faturamento[5] = 26742.6612;
faturamento[6] = 0.0;
faturamento[7] = 42889.2258;
faturamento[8] = 46251.174;
faturamento[9] = 11191.4722;
faturamento[10] = 0.0;
faturamento[11] = 0.0;
faturamento[12] = 3847.4823;
faturamento[13] = 373.7838;
faturamento[14] = 2659.7563;
faturamento[15] = 48924.2448;
faturamento[16] = 18419.2614;
faturamento[17] = 0.0;
faturamento[18] = 0.0;
faturamento[19] = 35240.1826;
faturamento[20] = 43829.1667;
faturamento[21] = 18235.6852;
faturamento[22] = 4355.0662;
faturamento[23] = 13327.1025;
faturamento[24] = 0.0;
faturamento[25] = 0.0;
faturamento[26] = 25681.8318;
faturamento[27] = 1718.1221;
faturamento[28] = 13220.495;
faturamento[29] = 8414.61;

int diasUteis = 0;
int diasFaturamentoAcimaMedia = 0;
double mediaFaturamento = 0.0;
double faturamentoMes = 0.0;

for (int i = 0; i < faturamento.Length; i++)
{
    if (faturamento[i] != 0)
    {
        diasUteis++;
    }
    faturamentoMes += faturamento[i];
}

mediaFaturamento = (faturamentoMes / diasUteis);

for (int i = 0; i < faturamento.Length; i++)
{
    if (faturamento[i] != 0 && faturamento[i] > mediaFaturamento)
    {
        diasFaturamentoAcimaMedia++;
    }
}

Console.WriteLine("Dias úteis: " + diasUteis);
Console.WriteLine("Faturamento Medio: " + mediaFaturamento.ToString("F2"));
Console.WriteLine("Menor faturamento: " + faturamento.Min().ToString("F2"));
Console.WriteLine("Maior faturamento: " + faturamento.Max().ToString("F2"));
Console.WriteLine("Dias com faturamento acima da média: " + diasFaturamentoAcimaMedia);
