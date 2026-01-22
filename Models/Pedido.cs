using System;
using System.Collections.Generic;
using System.Text;

namespace Refatora_Calculadora.Models
{
    public class Pedido
    {
        public int Quantidade { get; }
        public double ValorUnitario { get; }

        public Pedido(int quantidade, double valorUnitario)
        {
            if (quantidade <= 0)
                throw new ArgumentException("Quantidade inválida");

            if (valorUnitario <= 0)
                throw new ArgumentException("Valor unitário inválido");

            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public double ValorTotal => Quantidade * ValorUnitario;
    }
    }
