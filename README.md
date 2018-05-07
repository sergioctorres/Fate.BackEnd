# Fate.BackEnd
BackEnd WebApi com geração de banco via CodeFirst

### Instalação

```sh
* Necessário o SQL Server Instalado
- Abrir a Solução Fate.BackEnd;
- Digitar CTRL+SHIFT+B;
- Abrir "Package Manager Console", escolher o projeto "4 - Infra \ 4.1 - Data \ Fate.BackEnd.Infra", e digitar o comando update-database
- No projeto "1 - Services \Fate.BackEnd.Services.REST" alterar a connectionString no arquivo Web.Config;
- Definir o projeto "1 - Services \Fate.BackEnd.Services.REST" como Default para executar;
- Apertar F5 para executar a aplicação;
```

### Tecnologias
* .NET Framework
* DDD
* Arquitetura em camadas
* Injecao de Independência
* AutoMapper
* Interface
* ApiREST
* Entity Framework

### Ferramentas
* Visual Studio Community 2017
* SQL Server EXPRESS