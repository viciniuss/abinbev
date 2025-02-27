Como Rodar o Projeto

Requisitos
.NET Core 5.0 ou superior
PostgreSQL ou MongoDB configurado
Rebus para mensageria (configuração adicional)
Ferramenta de testes: Postman para testes manuais, xUnit para testes unitários

Passos para Executar

Configure o banco de dados:

Ajuste as conexões no arquivo appsettings.json para refletir suas credenciais e dados do banco de dados escolhido.
Execute as migrações do banco de dados (caso esteja usando PostgreSQL):

dotnet ef migrations remove (caso tenha alguma migration existente)
dotnet ef migrations add InitialCreate
dotnet ef database update

Execute o projeto:

dotnet run

Testes manuais da API:

Utilize o Postman ou outro cliente REST para testar as requisições da API, verificando funcionalidades como CRUD, filtros, paginação e ordenação.
Execute os testes unitários:

dotnet test