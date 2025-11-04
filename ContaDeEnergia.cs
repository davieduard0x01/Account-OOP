namespace GestaoEnergia
{
    public class ContaDeEnergia
    {
        private string _mesDeReferencia;
        private double _leituraAnterior;
        private double _leituraAtual;
        private double _consumoKwh;
        
        private static  double TarifaBasica = 0.92;
        private static  double ContrLuzPublica = 0.22;
        private static  double PercentualICMS = 0.18;

        private double _valorConsumo;
        private double _valorLuzPublica;
        private double _valorICMS;
        private double _valorTotal;

        public string MesDeReferencia => _mesDeReferencia;
        public double ConsumoKwh => _consumoKwh;
        public double ValorTotal => _valorTotal;

        public ContaDeEnergia(string mesDeReferencia, double leituraAnterior, double leituraAtual)
        {
            _mesDeReferencia = mesDeReferencia;
            _leituraAnterior = leituraAnterior;
            _leituraAtual = leituraAtual;

            CalcularConsumo();
            CalcularLuzPublica();
            CalcularICMS();
            CalcularValorTotal();
        }

        private void CalcularConsumo()
        {
            _consumoKwh = _leituraAtual - _leituraAnterior;
            _valorConsumo = _consumoKwh * TarifaBasica;
        }

        private void CalcularLuzPublica()
        {
            _valorLuzPublica = _consumoKwh * ContrLuzPublica;
        }

        private void CalcularICMS()
        {
            _valorICMS = _valorConsumo * PercentualICMS;
        }

        private void CalcularValorTotal()
        {
            _valorTotal = _valorConsumo + _valorLuzPublica + _valorICMS;
        }

        public ContaDeEnergia CompararConta(ContaDeEnergia outra)
        {
            if (this.ValorTotal > outra.ValorTotal)
            {
                return this;
            }
            else if (outra.ValorTotal > this.ValorTotal)
            {
                return outra;
            }
            return null;
        }

        public string MostrarResumo()
        {
            return $"Mês: {_mesDeReferencia} | Consumo: {_consumoKwh:N2} kWh | Total: {_valorTotal:C}";
        }
        
    }
}