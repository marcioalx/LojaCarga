
namespace LojaCargaRapida
{
     class Estacao
    {

        //propriedades (atributos)
        public string Mototrista { get; set; }
        public double CapacidadeKwh {  get; set; }
        public double PorcentagemAtual { get; set; }
        public double PotenciaKw { get; set; }

        // Metodos (ações)

        //Metodo calcular kw necessarios
        public double CalcularKwNecessarios () 
        {
            double porcentagemFaltantes = (100.00 - PorcentagemAtual) / 100;
            return CapacidadeKwh * porcentagemFaltantes;
        }

        // Metodo que calcula o tmepo necessario
        public double CalcularTempoHoras()
        {
            return CalcularKwNecessarios() / PotenciaKw;
        }

        //Metodo para saber o valor para carregar
        public double CalcularValor()
        {
            const double PRECO_POR_KWH = 2.50;
            return CalcularKwNecessarios() * PRECO_POR_KWH;
        }

        //Metodo para saber se o carregamento é rapido
        public bool CarregamentoRapido()
        {
            return (PotenciaKw >= 50.0) && (CalcularTempoHoras() < 1.0);
        }
    }
}
