using LocadoraDeCarros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Services
{
    internal class AluguelDoServico
    {
        public double PrecoHora { get; set; }
        public double PrecoDiaria { get; set; }
        public ImpostoEstadualMS ImpostoEstadualMS { get; private set; } = new ImpostoEstadualMS();
        public AluguelDoServico() { }
        public AluguelDoServico(double precoHora, double precoDiaria)
        {
            PrecoHora = precoHora;
            PrecoDiaria = precoDiaria;
        }
        public void ProcessarFatura(AluguelDeCarros aluguelDeCarros) 
        {
            TimeSpan duracao = aluguelDeCarros.Devolucao.Subtract(aluguelDeCarros.Retirada);
            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12)
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoDiaria * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = ImpostoEstadualMS.Imposto(pagamentoBasico);
            aluguelDeCarros.Fatura = new Fatura(pagamentoBasico, imposto);
        }
    }
}
