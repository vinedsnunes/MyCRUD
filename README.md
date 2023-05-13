# API CRUD em .NET Core

Esta é uma API CRUD básica desenvolvida em .NET para realizar operações de criação, leitura, atualização e exclusão (CRUD) em um banco de dados. Ela fornece endpoints HTTP para manipulação de recursos através dos métodos GET, POST, PUT e DELETE.

## Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0) versão 7.0.203
- Um banco de dados (SQL Server)

## Instalação

1. Clone este repositório em sua máquina local:

2. Navegue até o diretório do projeto:

3. Restaure as dependências do projeto:

4. Configure a conexão com o banco de dados no arquivo `appsettings.json`.

5. Execute as migrações para criar as tabelas do banco de dados:

## Uso

1. Inicie a aplicação:

2. A API estará disponível no seguinte URL: https://localhost:7168

3. Utilize um cliente HTTP (por exemplo, Postman, cURL) para fazer requisições aos endpoints disponíveis. Aqui estão alguns exemplos de endpoints:

- **GET** `/api/v1/product`: Retorna todos os produtos.
- **GET** `/api/v1/product/{id}`: Retorna um produto específico.
- **POST** `/api/v1/product`: Cria um novo produto.
- **PUT** `/api/v1/product`: Atualiza um produto existente.
- **DELETE** `/api/v1/product/{id}`: Exclui um produto.

Certifique-se de fornecer os parâmetros corretos nas requisições, conforme definido pela API.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request ou reportar problemas.

## Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo `LICENSE` para obter mais detalhes.

## Contato

Se você tiver alguma dúvida ou sugestão, entre em contato através do email: vinicius.dsnunes@outlook.com.
