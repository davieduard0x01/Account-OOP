using System.Collections.Generic;
using System.Linq;

namespace GestaoEnergia
{
    public class Imovel
    {
        private int _codigoRegistro;
        private List<ContaDeEnergia> _contas;

        public int CodigoRegistro => _codigoRegistro;

        public Imovel(int codigoRegistro)
        {
            _codigoRegistro = codigoRegistro;
            _contas = new List<ContaDeEnergia>();
        }

        public void AdicionarConta(ContaDeEnergia novaConta)
        {
            _contas.Add(novaConta);
        }

        public double CalcularValorMedio()
        {
            if (!_contas.Any())
            {
                return 0;
            }
            return _contas.Average(c => c.ValorTotal);
        }

        public double ContaMaisCara()
        {
            if (!_contas.Any())
            {
                return 0;
            }
            return _contas.Max(c => c.ValorTotal);
        }

        public List<ContaDeEnergia> ContasAcimaDaMedia()
        {
            if (!_contas.Any())
            {
                return new List<ContaDeEnergia>();
            }

            double media = CalcularValorMedio();
            
            return _contas.Where(c => c.ValorTotal > media).ToList();
        }

        public string ResumoAnual()
        {
            if (!_contas.Any())
            {
                return "Nenhuma conta registrada para este imóvel.";
            }

            double valorMedio = CalcularValorMedio();
            double valorTotalAcumulado = _contas.Sum(c => c.ValorTotal);
            int totalContas = _contas.Count;

            return $"Resumo do Imóvel {_codigoRegistro}:\n" +
                   $"Total de Contas: {totalContas}\n" +
                   $"Valor Total Acumulado: {valorTotalAcumulado:C}\n" +
                   $"Valor Médio Mensal: {valorMedio:C}\n" +
                   $"Conta mais cara: {ContaMaisCara():C}";
        }
    }
    
}