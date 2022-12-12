using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Entities
{
    internal class Veiculo
    {
        public string NomeModelo { get; set; }
        public Veiculo() { }
        public Veiculo(string nomeModelo)
        {
            NomeModelo = nomeModelo;
        }
    }
}
