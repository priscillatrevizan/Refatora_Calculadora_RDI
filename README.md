## Exercício – Clean Code

### Refatoração: Calculadora de Vendas em C#

Este projeto foi realizado por Priscilla Braun Trevizan Tomazi e Allexia Desirée Lefundes Nascimento. Seu objetivo é demonstrar a refatoração de um método de cálculo de pagamentos, aplicando princípios de Clean Code (Código Limpo). Ele foi apresentado dentro do bootcamp CodeRDIversity, uma parceria entre RDI Software e Prosper Dgital Skills.

### Descrição

Você está trabalhando em um sistema de vendas.
A classe abaixo tem um único método responsável por calcular o valor final de um pagamento:
- Recebe dados de um pedido (quantidade, valor unitário do item, tipo de cliente, se ele tem desconto ou não)
- Válida se os valores são válidos (quantidade e valor do item devem ser diferente de 0)
- Calcula o valor total da compra (quantidade * valorUnitário)
- Aplica desconto dependendo do tipo de cliente:

	> **Cliente Regular** tem 5% de desconto
	> **ClientePremium** tem 10% de desconto
	> **ClienteVip** tem 15% de desconto
- 
### Código Base:
 ```
 public class P{
    public double M(int q, double p, int t, bool d){
        double r = 0;
        if (q <= 0 || p <= 0){ return 0; }


        if (t == 1){
            r = q * p;
            if (d){
                r = r - (r * 0.05);
            }
        }
        else if (t == 2){
            r = q * p;
            if (d)
            {
                r = r - (r * 0.10);
            }
        }
        else if (t == 3){
            r = q * p;
            if (d){ r = r - (r * 0.15); }
        }
        else{
            r = q * p;
        }


        return r;
    }
}
````
