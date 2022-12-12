using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Entities
{
    internal class AluguelDeCarros
    {
        public DateTime Retirada { get; set; }
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }
        public AluguelDeCarros() { }
        public AluguelDeCarros(DateTime retirada, DateTime devolucao, Veiculo veiculo)
        {
            Retirada = retirada;
            Devolucao = devolucao;
            Veiculo = veiculo;
        }

    }
}
