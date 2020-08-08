[01] - Erro ao retornar JSON na gravação de um novo registro
- [Mensagem]: "System.Text.Json.JsonException: A possible object cycle was detected which is not supported. This can either be due to a cycle or if the object depth is larger than the maximum allowed depth of 32"
- [Resolução]: "Foi adicionado o pacote Microsoft.AspNetCore.Mvc.NewtonsoftJson a na StartUp.cs foi mudado o AddControllers()"

`Startup.cs`

```csharp
//[01]
services.AddControllers()
                .AddNewtonsoftJson(options => 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
```