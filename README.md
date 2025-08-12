# 📞 Sistema de Gerenciamento de Contatos

Um sistema CRUD completo desenvolvido com **ASP.NET Core MVC** para gerenciamento de contatos, permitindo criar, visualizar, editar e excluir registros de forma intuitiva e organizada.

## 🚀 Funcionalidades

- ✅ **Criar** novos contatos com nome, telefone e status
- 👁️ **Visualizar** lista completa de contatos
- ✏️ **Editar** informações existentes
- 🗑️ **Excluir** contatos com confirmação
- 📱 Interface responsiva com Bootstrap
- 🔄 Status ativo/inativo para cada contato

## 🛠️ Tecnologias Utilizadas

- **Framework:** ASP.NET Core 8.0 MVC
- **ORM:** Entity Framework Core 9.0.8
- **Banco de Dados:** SQL Server
- **Frontend:** Bootstrap, HTML5, CSS3
- **IDE:** Visual Studio 2022

## 📋 Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) ou SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## ⚡ Como Executar

### 1. Clone o repositório
```bash
git clone https://github.com/seu-usuario/MVCASPNET.git
cd MVCASPNET
```

### 2. Configure a string de conexão
Edite o arquivo `appsettings.Development.json` e ajuste a string de conexão conforme sua configuração do SQL Server:

```json
{
  "ConnectionStrings": {
    "ConexaoPadrao": "Server=localhost\\sqlexpress;Initial Catalog=AgendaMVC;Integrated Security=True;TrustServerCertificate=True"
  }
}
```

### 3. Execute as migrações
```bash
dotnet ef database update
```

### 4. Execute o projeto
```bash
dotnet run
```

O sistema estará disponível em:
- **HTTPS:** https://localhost:7047
- **HTTP:** http://localhost:5063

## 📁 Estrutura do Projeto

```
MVCASPNET/
├── 📂 Controllers/
│   ├── ContatoController.cs    # CRUD de contatos
│   └── HomeController.cs       # Página inicial
├── 📂 Models/
│   ├── Contato.cs             # Modelo de dados
│   └── ErrorViewModel.cs      # Modelo de erro
├── 📂 Views/
│   ├── 📂 Contato/            # Views do CRUD
│   ├── 📂 Home/               # Página inicial
│   └── 📂 Shared/             # Layout compartilhado
├── 📂 Context/
│   └── AgendaContext.cs       # Contexto do Entity Framework
├── 📂 Migrations/             # Migrações do banco
└── Program.cs                 # Configuração da aplicação
```

## 🎯 Funcionalidades Detalhadas

### Modelo de Dados
```csharp
public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public bool Ativo { get; set; }
}
```

### Operações Disponíveis
- **GET /Contato** - Lista todos os contatos
- **GET /Contato/Criar** - Formulário de criação
- **POST /Contato/Criar** - Salva novo contato
- **GET /Contato/Editar/{id}** - Formulário de edição
- **POST /Contato/Editar** - Atualiza contato
- **GET /Contato/Detalhes/{id}** - Visualiza detalhes
- **GET /Contato/Deletar/{id}** - Confirmação de exclusão
- **POST /Contato/Deletar** - Remove contato

## 🎨 Interface

O sistema possui uma interface moderna e responsiva com:
- Design clean utilizando Bootstrap
- Navegação intuitiva
- Formulários validados
- Confirmação para operações críticas
- Feedback visual para ações do usuário

## 🔧 Configurações

### Entity Framework
```csharp
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));
```

### Roteamento
```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

## 📊 Banco de Dados

O sistema utiliza uma tabela simples:

**Tabela: Contatos**
| Campo    | Tipo         | Descrição                |
|----------|--------------|--------------------------|
| Id       | int          | Chave primária (Identity)|
| Nome     | nvarchar(max)| Nome do contato         |
| Telefone | nvarchar(max)| Número de telefone      |
| Ativo    | bit          | Status do contato       |


--------------------------------------------------------------------------
## 👨‍💻 Autor

**Caio H Santana**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/caiohsantana)

