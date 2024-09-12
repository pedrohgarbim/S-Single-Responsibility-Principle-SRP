// Single Responsibility Principle (SRP)
//Descrição: Cada classe deve ter uma única responsabilidade.
//Ou seja, ela deve fazer apenas uma coisa.




// violando o principio SRP, Aqui, temos uma classe Invoice que tem múltiplas responsabilidades:
// calcular o total da fatura e também salvar a fatura no banco de dados.
// O problema dessa classe é que Problema: A classe tem mais de uma responsabilidade:
// calcular o total da fatura e salvar no banco de dados. Isso viola o SRP.



// Com SRP (respeitando o princípio):
// O correto é separar as responsabilidades em diferentes classes,
// mantendo cada uma com uma única função.


using SOLID1SRP.NO_SRP;
using SOLID1SRP.WITH_SRP;

var invoice = new CorrectInvoice { Products = new List<Product> { new Product { Name = "Laptop", Price = 1000 } } };
invoice.CalculateTotal();

var repo = new InvoiceRepository();
repo.SaveToDatabase(invoice);


// Agora, a classe Invoice só cuida do cálculo da fatura,
// enquanto InvoiceRepository cuida do armazenamento.
// Cada classe tem uma única responsabilidade de forma que segue o principio
// Single Responsibility Principle.

