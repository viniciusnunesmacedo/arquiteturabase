
Camada ArquiteturaBase.WebApi

Adicionado as referencias:

Swashbuckle.AspNetCore
MediatR.Extensions.Microsoft.DependencyInjection
---------------------------------------------------------------------------------------------
Camada ArquiteturaBase.Infraestrutura.Dados

Adicionado as referencias:

Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.FileExtensions
Microsoft.Extensions.Configuration.Json
---------------------------------------------------------------------------------------------

Camada Camada ArquiteturaBase.Infraestrutura.InversaoControle

Adicionado as referencias:

Autofac.Extensions.DependencyInjection

---------------------------------------------------------------------------------------------

Camada ArquiteturaBase.Infraestrutura.Transversal.Identidade

Adicionado as referencias:

microsoft.aspnetcore.identity
microsoft.entityframeworkcore.sqlserver
Microsoft.EntityFrameworkCore.Tools.DotNet
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.FileExtensions
Microsoft.Extensions.Configuration.Json

não esquecer de rodar o build antes de rodar o migrations

abrir a console dentro da pasta ArquiteturaBase.Infraestrutura.Transversal.Identidade\

executar o comando: dotnet ef migrations add inicio
executar o comando: dotnet ef database update