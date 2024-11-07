 
# 🧑‍💼 Single Responsibility Principle (SRP) 
![image](https://github.com/user-attachments/assets/5ceb0f88-11e7-4625-97f4-bd25927b4d09)
## O que é o SRP? 

O **Princípio da Responsabilidade Única (SRP)** afirma que uma classe deve ter **apenas uma razão para mudar**, ou seja, ela deve ter uma única responsabilidade ou função no sistema. 📋 Isso garante que cada classe tenha uma função específica, o que facilita a manutenção 🛠️ e a evolução do software.

### 🚨 Problema comum:

Imagine uma classe que tenta fazer várias coisas ao mesmo tempo. Por exemplo, uma classe `Invoice` que calcula o total da fatura 🧮 e também salva a fatura no banco de dados 🗄️. Se você precisar modificar a lógica de cálculo, você também corre o risco de introduzir um bug na parte de armazenamento. 🐛

### ✅ Solução com SRP:

A solução é simples: divida as responsabilidades! 🙌 Crie uma classe para calcular o total 🧮 e outra para salvar a fatura 🗄️. Cada classe tem uma única responsabilidade, o que facilita sua manutenção.

### 🛠️ Explicação do Projeto:

No projeto implementando o SRP:
- Criamos a classe `Invoice` 🎟️ para **calcular o total da fatura**.
- Criamos a classe `InvoiceRepository` 💾 que tem a única função de **salvar a fatura no banco de dados**.

#### 🎯 Benefícios:
- **Facilidade de manutenção**: Agora, se precisarmos alterar a forma de calcular o total, só mexemos na classe `Invoice`. Se precisarmos alterar o armazenamento, só modificamos `InvoiceRepository`.
- **Testabilidade**: Cada classe pode ser testada 🧪 separadamente, tornando o código mais confiável e previsível. 
## Estrutura do projeto
  ![image](https://github.com/user-attachments/assets/dde9f3af-f5b4-4f9f-a44e-bd1f44ff122f)

