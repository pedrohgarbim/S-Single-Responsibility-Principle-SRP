using SOLID1SRP.NO_SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1SRP.WITH_SRP
{
    public class InvoiceRepository
    {
        public void SaveToDatabase(CorrectInvoice invoice)
        {
            // Código que salva a fatura no banco de dados
            Console.WriteLine("Fatura salva no banco de dados.");
        }
    }
}
