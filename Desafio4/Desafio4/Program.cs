/*
 * 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  */


List<Estado> estados = new List<Estado>()
{
    new Estado { UF = "SP", Faturamento = 67836.43 },
    new Estado { UF = "RJ", Faturamento = 36678.66 },
    new Estado { UF = "MG", Faturamento = 29229.88 },
    new Estado { UF = "ES", Faturamento = 27165.48 },
    new Estado { UF = "Outros", Faturamento = 19849.53 }
};


double totalFaturamento = 0;
foreach (var item in estados)
{
    totalFaturamento += item.Faturamento;
}


foreach (var item in estados)
{
    item.Porcentagem = (item.Faturamento / totalFaturamento) * 100;
}


foreach (var item in estados)
{
    Console.WriteLine($"Percentual de representação do estado {item.UF} no valor total mensal da distribuidora: {item.Porcentagem:F2}%");
}


class Estado
{
    public string UF { get; set; }
    public double Faturamento { get; set; }
    public double Porcentagem { get; set; }
}