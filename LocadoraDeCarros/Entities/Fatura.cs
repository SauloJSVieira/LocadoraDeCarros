using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Entities
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }
        public double ValorTotal { get { return PagamentoBasico + Imposto; } } //Propriedade Get calculada
        public Fatura() { }
        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public override string ToString()
        {
            return
                "\n\rPagmento Básico: "
                + PagamentoBasico.ToString("f2",CultureInfo.InvariantCulture) +
                "\nImposto: "
                + Imposto.ToString("f2",CultureInfo.InvariantCulture) +
                "\nValor Total: "
                + ValorTotal.ToString("f2", CultureInfo.InvariantCulture);                
        }
    }
}
