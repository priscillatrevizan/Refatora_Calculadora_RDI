using System;
using System.Collections.Generic;
using System.Text;

namespace Refatora_Calculadora.Models
{
    public class Cliente
    {
        public TipoCliente Tipo { get; }
        public double PercentualDesconto { get; }

        public Cliente(TipoCliente tipo)
        {
            Tipo = tipo;
            PercentualDesconto = ObterDesconto(tipo);
        }

        private double ObterDesconto(TipoCliente tipo)
        {
            return tipo switch
            {
                TipoCliente.Regular => 0.05,
                TipoCliente.Premium => 0.10,
                TipoCliente.Vip => 0.15,
                _ => 0
            };
        }
    }
}

