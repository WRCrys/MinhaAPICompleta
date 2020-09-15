## Dependências usadas no projeto

##### Instalando o Entity Framework Core

Visual Studio IDE
`Install-Package Microsoft.EntityFrameworkCore`

Dotnet CLI
`dotnet add package Microsoft.EntityFrameworkCore`


------------


##### Instalando os pacotes necessários para o Identity

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore`

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Identity.UI`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Identity.UI`


------------


##### Instalando o Relational do Entity Framework Core para conseguirmos mapear o tipo e tamanho das colunas

Visual Studio IDE
`Install-Package Microsoft.EntityFrameworkCore.Relational`

Dotnet CLI
`dotnet add package Microsoft.EntityFrameworkCore.Relational`


------------


#### Configurando o Automapper para o uso de ViewModel

Visual Studio IDE
`Install-Package automapper.extensions.microsoft.dependencyinjection`

Dotnet CLI
`dotnet add package automapper.extensions.microsoft.dependencyinjection`


------------


##### Framework para validação de negócio: [Fluent Validation](http://https://docs.fluentvalidation.net/en/latest/installation.html "Fluent Validation")

Visual Studio IDE
`Install-Package FluentValidation`

Dotnet CLI
`dotnet add package FluentValidation`


------------


##### Caso queria criar um script sql precisará do pacote abaixo

Visual Studio IDE
`Install-Package Microsoft.EntityFrameworkCore.Sqlserver`

Dotnet CLI
`dotnet add package Microsoft.EntityFrameworkCore.Sqlserver`


------------


##### Instalando o NewtonsoftJson para solucionar o problema 01 citado no arquivo de dificuldades de projeto

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson`


------------


##### Pacote do JWT Bearer

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Authentication.JwtBearer`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer`


------------


##### Instalando o pacote para o versionamento da api

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Mvc.Versioning`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Mvc.Versioning`

Visual Studio IDE
`Install-Package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer`

Dotnet CLI
`dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer`


------------


##### Implementação do Swagger

Visual Studio IDE
`Install-Package Swashbuckle.AspNetCore`

Dotnet CLI
`dotnet add package Swashbuckle.AspNetCore`


------------


##### Implementação do ElmahIO

Visual Studio IDE
`Install-Package Elmah.Io.AspNetCore`

Para monitorar os logs da aplicação
`Install-Package Elmah.Io.Extensions.Logging`

Dotnet CLI
`dotnet add package Elmah.Io.AspNetCore`

Para monitorar os logs da aplicação
`dotnet add package Elmah.Io.Extensions.Logging`


------------


##### Implementação do HealthCheck

Visual Studio IDE
- Para o SQL Server
`Install-Package AspNetCore.HealthChecks.SqlServer`

- Para a interface visual
`Install-Package AspNetCore.HealthChecks.Ui`

- Para a memória
`Install-Package AspNetCore.HealthChecks.UI.InMemory.Storage`

- Para os responses
`Install-Package AspNetCore.HealthChecks.Ui.Client`

- Enviando para o Elmah
`Install-Package Elmah.Io.AspNetCore.HealthChecks`

Dotnet CLI
- Para o SQL Server
`dotnet add package AspNetCore.HealthChecks.SqlServer`

- Para a interface visual
`dotnet add package AspNetCore.HealthChecks.Ui`

- Para a memória
`dotnet add package AspNetCore.HealthChecks.UI.InMemory.Storage`

- Para os responses
`dotnet add package AspNetCore.HealthChecks.Ui.Client`

- Enviando para o Elmah
`dotnet add package Elmah.Io.AspNetCore.HealthChecks`


------------