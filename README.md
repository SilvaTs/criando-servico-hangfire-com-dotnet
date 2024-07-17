
# Projeto Hangfire com .NET 8

Este projeto é um serviço desenvolvido em .NET 8 utilizando Hangfire para gerenciamento de tarefas em background. Ele inclui uma API para criar e gerenciar jobs (tarefas) e um dashboard para visualizar o status dessas tarefas.

## Links Importantes

- **Dashboard do Hangfire**: [https://localhost:7237/hangfire/jobs/scheduled](https://localhost:7237/hangfire/jobs/scheduled)
- **Swagger da API**: [https://localhost:7237/swagger/index.html](https://localhost:7237/swagger/index.html)

## Endpoints da API

### POST /job

**Request Body:**
```json
"string"
```

**Response**
```json
"string"
```

### POST /job/delayed

**Request Body:**
```json
"string"
```

**Response**
```json
"string"
```

### POST /job/continuation

**Request Body:**
```json
"string"
```

**Response**
```json
"string"
```

## Instruções para Criar o Banco de Dados e Tabelas

Para utilizar o Hangfire com um banco de dados SQL Server, siga as instruções abaixo para criar o banco de dados e as tabelas necessárias:

### Criar Banco de Dados

```sql
-- Cria o banco de dados HangFire
CREATE DATABASE HangFire;
GO

-- Seleciona o banco de dados HangFire para uso
USE HangFire;
GO
```

### Criar Tabela State

```sql
-- Cria a tabela State
CREATE TABLE State (
    Id INT PRIMARY KEY IDENTITY(1,1),
    JobId INT NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Reason NVARCHAR(MAX) NULL,
    CreatAdt DATETIME NOT NULL DEFAULT GETDATE(),
    Data NVARCHAR(MAX) NOT NULL
);
GO
```

### Criar Tabela Job

```sql
-- Cria a tabela Job
CREATE TABLE Job (
    Id INT PRIMARY KEY IDENTITY(1,1),
    StateId INT NOT NULL,
    StateName NVARCHAR(255) NOT NULL,
    InvocationData NVARCHAR(MAX) NOT NULL,
    Arguments NVARCHAR(MAX) NOT NULL,
    CreatAdt DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (StateId) REFERENCES State(Id)
);
GO
```

## Como Rodar o Projeto

1. **Clone o repositório**:
   ```sh
   git clone https://github.com/SilvaTs/criando-servico-hangfire-com-dotnet.git
   ```

2. **Navegue até o diretório do projeto**:
   ```sh
   cd criando-servico-hangfire-com-dotnet
   ```

3. **Se você estiver usando o VS CODE Restaure os pacotes NuGet**:
   ```sh
   dotnet restore
   ```

4. **Configure o banco de dados**:
   - Certifique-se de que o SQL Server está rodando.
   - Execute os scripts SQL fornecidos acima para criar o banco de dados e as tabelas.

5. **Se você estiver usando o VS CODE Execute a aplicação**:
   ```sh
   dotnet run --project Hangfire
   ```

6. **Acesse o dashboard do Hangfire**:
   - Abra seu navegador e acesse [https://localhost:7237/hangfire/jobs/scheduled](https://localhost:7237/hangfire/jobs/scheduled)

7. **Acesse a documentação da API**:
   - Abra seu navegador e acesse [https://localhost:7237/swagger/index.html](https://localhost:7237/swagger/index.html)

## Contribuição

Se você deseja contribuir com o projeto, sinta-se à vontade para fazer um fork do repositório, criar uma nova branch e submeter um pull request.

## Licença

Este projeto está licenciado sob os termos da [MIT License](LICENSE).

---

Desenvolvido por [Daniel Silva](https://github.com/SilvaTs).
