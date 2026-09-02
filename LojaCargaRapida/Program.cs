using LojaCargaRapida;

Console.WriteLine("=== SISTEMA DE RECARGA===");
Console.WriteLine();

// 1. Instanciando o objeto da classe
Estacao carga = new Estacao();

// 2. Leitura dos dados e atribuição ao objeto
Console.Write("Digite o nome do motorista: ");
carga.Motorista = Console.ReadLine();

Console.Write("Capacidade total da bateria (kWh): ");
carga.CapacidadeKwh = Convert.ToDouble(Console.ReadLine());

Console.Write("Carga atual da bateria (%): ");
carga.PorcentagemAtual = double.Parse(Console.ReadLine());

Console.Write("Potência do carregador (kW): ");
carga.PotenciaKw = double.Parse(Console.ReadLine());

// 3. Exibição utilizando os métodos do objeto instanciado
Console.WriteLine("\n--- COMPROVANTE DE SESSÃO ---");
Console.WriteLine($"Cliente: {carga.Motorista.Trim().ToUpper()}");
Console.WriteLine($"Carga Faltante: {carga.CalcularKwNecessarios():F1} kWh");
Console.WriteLine($"Tempo Estimado: {carga.CalcularTempoHoras():F2} hora(s)");
Console.WriteLine($"Valor a Pagar: R$ {carga.CalcularValor():N2}");
Console.WriteLine($"Sessão Super-Rápida? {carga.CarregamentoRapido()}");