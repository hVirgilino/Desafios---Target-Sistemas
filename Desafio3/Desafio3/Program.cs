/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
*/
using Newtonsoft.Json;
// Carregar dados do JSON

try
{
    string json = File.ReadAllText("../../../faturamento.json");
    DiaValorFaturamento[] faturamento = JsonConvert.DeserializeObject<DiaValorFaturamento[]>(json);

    var diasComValor = faturamento.Where(d => d.Valor > 0).ToArray();

    double menorFaturamento = diasComValor.Min(d => d.Valor);
    double maiorFaturamento = diasComValor.Max(d => d.Valor);

    double mediaMensal = diasComValor.Average(d => d.Valor);

    int diasAcimaDaMedia = diasComValor.Count(d => d.Valor > mediaMensal);

    // Exibir resultados
    Console.WriteLine($"Menor faturamento: {menorFaturamento}");
    Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
    Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");

}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao carregar o arquivo JSON: {ex.Message}");
}


class DiaValorFaturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}
