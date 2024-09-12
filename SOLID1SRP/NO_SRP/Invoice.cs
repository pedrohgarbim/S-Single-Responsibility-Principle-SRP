using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1SRP.NO_SRP
{
    public class Invoice
    {
        public List<ProductWrong> Products { get; set; }
        public double Total { get; private set; }

        public void CalculateTotal()
        {
            foreach (var product in Products)
            {
                Total += product.Price;
            }
        }
        public void SaveToDatabase()
        {
            // Código que salva a fatura no banco de dados
            Console.WriteLine("Fatura salva no banco de dados.");
        }

    }
}

// violando o principio SRP, Aqui, temos uma classe Invoice que tem múltiplas responsabilidades:
// calcular o total da fatura e também salvar a fatura no banco de dados.
// O problema dessa classe é que Problema: A classe tem mais de uma responsabilidade:
// calcular o total da fatura e salvar no banco de dados. Isso viola o SRP.