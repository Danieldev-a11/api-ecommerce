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

Controllers
Responsáveis por receber as requisições e executar as ações da API.

Models
Representam os dados utilizados pela aplicação, como clientes e pedidos.
Docker
Ferramenta utilizada para executar a aplicação dentro de containers.

Funcionamento
O cliente envia uma requisição para a API. A API recebe essa requisição e encaminha para o Controller responsável. O sistema processa a informação e retorna uma resposta para o cliente.

Clientes
A API permite criar clientes, consultar clientes e buscar um cliente pelo ID.

Pedidos
A API permite criar pedidos, consultar pedidos e relacionar pedidos aos clientes.

Objetivo
O objetivo deste projeto é praticar o desenvolvimento de APIs REST utilizando C#, ASP.NET Core, HTTP, JSON, Controllers e Models.