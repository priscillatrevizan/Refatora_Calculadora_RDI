using System;

namespace Refatora_Calculadora.Models
{
    public class Calculadora
    {
        public double CalcularValorFinal( Pedido pedido, Cliente cliente)
        {

            if (pedido == null) return 0;

            if (cliente == null) return 0;

            double total = pedido.ValorTotal;

            if (cliente.PercentualDesconto <= 0)
            {
                return total;
            }

            return total - (total * cliente.PercentualDesconto);

        }
    }
}

