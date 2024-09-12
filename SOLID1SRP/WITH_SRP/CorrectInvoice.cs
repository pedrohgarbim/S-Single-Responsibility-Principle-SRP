using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1SRP.WITH_SRP
{
    public class CorrectInvoice
    {
        public List<Product> Products { get; set; }
        public double Total { get; private set; }

        public void CalculateTotal()
        {
            foreach (var product in Products)
            {
                Total += product.Price;
            }
        }
    }

}

// Agora a classe faz apenas a sua função