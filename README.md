![](https://gixnetwork.org/wp-content/uploads/2019/04/Microsoft-logo_rgb_gray-1024x459.png)
# MinhaApiCompleta

![](https://img.shields.io/github/stars/wrcrys/MinhaApiCompleta.svg) ![](https://img.shields.io/github/forks/wrcrys/MinhaApiCompleta.svg) ![](https://img.shields.io/github/issues/wrcrys/MinhaApiCompleta.svg)

##### [Dependencias](https://github.com/WRCrys/MinhaApiCompleta/blob/master/Dependencias.md) usadas no projeto 

## Dificuldades no desenvolvimento

Ao longo do desenvolvimento encontrei alguns obstáculos que eu decidi documentar a fim de me ajudar em futuros projetos e ajudar quem estiver vendo o projeto
o arquivo [Dificuldade de Projeto](https://github.com/WRCrys/MinhaApiCompleta/blob/master/Dificuldades%20de%20Projeto.md) contém um padrão onde tem um id e esse ai estará visivel como comentário no código fonte assim:

`ApiConfig.cs`

```csharp
//[01]
services.AddControllers()
                .AddNewtonsoftJson(options => 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
```
Lá tu encontrará o erro e a solução aplicada e assim vai para todos os erros que estiverem catalogados. :tw-1f604:


### Status do desenvolvimento

- [x] Desenvolvendo
- [x] Concluído


## Comandos para o Gerenciador de Pacotes

#### Configurando o seu próprio contexto
##### Adicionando a nossa migration para criarmos o banco passando o contexto pois nessa aplicação temos dois contextos e não é entendido quando tem mais de um.

PM> `Add-Migration Initial  -Context MeuDbContext`


------------


##### Criando um script sql a partir da migration do contexto escolhido.

PM> `Script-Migration -Context MeuDbContext -v`


------------


##### Caso queria criar o banco direto use o comando abaixo.

Caso tenha mais de um contexto, escolha e passe...
PM> `Update-Database -Context MeuDbContext`

Caso não...
PM> `Update-Database`


------------


##### Fazendo deploy para o Azure.

Configure tudo no perfil de deploy, primeiro o servidor e a aplicação, posteriormente o servidor sql, no nosso caso o SQL Server e o novo banco.
O Azure irá automaticamente colocar a connection string pontada para o banco na nuvem.
Se já tiver configurado os hosts environments tudo bem, se não seria bom separar os ambientes.
Como o banco na nuvem não tem as nossas tabelas, você precisará configurar pelo visual studio, para isso é importante apontar a variável de ambiente
no console do gerenciador de pacotes.

PM> `$env:ASPNETCORE_ENVIRONMENT='Production'`

Agora é só rodar o comando para criar os contextos e pronto!!