﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Services
{
    internal class ImpostoEstadualMS
    {
        public double Imposto(double valor) 
        {
            if (valor <= 100 )
            {
                return valor * 0.20;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
