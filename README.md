# 🛒 API E-commerce

API REST desenvolvida em C# com ASP.NET Core para gerenciamento de clientes e pedidos.

## 🛠️ Tecnologias e ferramentas

### C#
Linguagem utilizada para desenvolver toda a API.

### ASP.NET Core
Framework utilizado para criar a API REST, receber requisições HTTP e retornar respostas.

### Visual Studio
IDE utilizada para escrever, organizar, executar e testar o projeto.

### Swagger
Ferramenta utilizada para visualizar e testar os endpoints da API diretamente pelo navegador.

### HTTP
Protocolo utilizado para a comunicação entre o cliente e a API.

Principais métodos utilizados:

- `GET` → consultar dados
- `POST` → criar dados
- `PUT` → atualizar dados
- `DELETE` → excluir dados

### JSON
Formato utilizado para enviar e receber dados entre o cliente e a API.

Exemplo:

```json
{
  "name": "João",
  "email": "joao@email.com"
}





Controllers
Responsáveis por receber as requisições e executar as ações da API.
Exemplo:
CustomersController → gerenciamento de clientes
OrdersController → gerenciamento de pedidos
Models
Representam os dados utilizados pela aplicação.
Exemplo:
Customer → representa um cliente
Order → representa um pedido
Docker
Utilizado para criar e executar a aplicação dentro de um container, facilitando a execução do projeto em diferentes ambientes.


📁 Estrutura do projeto


api_ecommerce/
│
├── Controllers/
│   ├── CustomersController.cs
│   └── OrdersController.cs
│
├── Models/
│   ├── Customer.cs
│   └── Order.cs
│
├── Program.cs
├── appsettings.json
├── Dockerfile
└── README.md


🔄 Como a API funciona
O cliente envia uma requisição HTTP para a API.


Cliente
   ↓
API
   ↓
Controller
   ↓
Sistema / Regras da aplicação
   ↓
Banco de dados



API recebe os dados, o Controller identifica qual operação deve ser realizada e a aplicação processa a solicitação.



👤 Clientes
A API permite:
Criar clientes
Consultar clientes
Buscar um cliente pelo ID

📦 Pedidos
A API permite:
Criar pedidos
Consultar pedidos
Associar um pedido a um cliente
Informar o produto e a quantidade
Controlar o status do pedido

🚀 Objetivo do projeto
Este projeto foi desenvolvido para praticar a criação de APIs REST utilizando C#, ASP.NET Core, Controllers, Models, HTTP e JSON.