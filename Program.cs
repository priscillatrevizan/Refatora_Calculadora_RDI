using System;
using Refatora_Calculadora.Models;

class Program
{
    static void Main()
    {
        bool executar = true;

        while (executar)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE VENDAS ===");

            Console.Write("Quantidade: ");
            int quantidade = LerInt();

            Console.Write("Valor unitário: ");
            double valorUnitario = LerDouble();

            TipoCliente tipoCliente = MenuTipoCliente();

            var pedido = new Pedido(quantidade, valorUnitario);
            var cliente = new Cliente(tipoCliente);

            var calculadora = new Calculadora();
            double total = calculadora.CalcularValorFinal(pedido, cliente);

            Console.WriteLine($"\nValor final com desconto: {total:C}");
            Console.ReadKey();
        }

        static TipoCliente MenuTipoCliente()
        {
            Console.WriteLine("\nTipo de cliente:");
            Console.WriteLine("1 - Regular (5%)");
            Console.WriteLine("2 - Premium (10%)");
            Console.WriteLine("3 - Vip (15%)");
            Console.Write("Escolha: ");

            return (TipoCliente)LerInt();
        }

        static int LerInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                    return valor;

                Console.Write("Valor inválido. Tente novamente: ");
            }
        }

        static double LerDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double valor))
                    return valor;

                Console.Write("Valor inválido. Tente novamente: ");
            }
        }
    }
}

