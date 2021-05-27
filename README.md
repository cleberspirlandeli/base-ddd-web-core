# Base Backend - Estrutura DDD com versionamento de Endpoints

<br/>

Objetivo:
- Criar uma estrutura base, separando responsabilidades com base na estrutura DDD.
- Realizar versionamento de `endpoints`
- Retorno padronizado e inclusive erros
- Erros gerados serão incluidos em uma lista ao em vez de gerar um `New Error`
- Documentação da API utilizando `Swagger`
- Utilizar AutoMapper
- Validação de regras de negocio com FluentValidation
- Captação de informações para monitoramento da API utilizando `Prometheus`
- TODO - Apresentação das informações de monitoramento em gráficos com `Grafana`
- TODO - Autenticação com `JWT`
- TODO - Implementar `ASP.NET Identity` com permissões de acesso com `Claims` e `Roles`
- TODO - Subir aplicação no `IIS local` e no `Azure`
- TODO - Implementar Testes automatizados
- TODO - Implementar Ambiente Docker
- TODO - Conversão de 3.1 para 5.x

<br/>
<br/>

## Tecnologias
- Banco de dados SQL Server
- .Net Core 3.1

## Frameworks e Packages
- EntityFramework
- FluentValidation
- Api Version
- AutoMapper

<br/>
<br/>

<br>

## Como executar

Criar banco de dados com o nome `MinhaAppMvcCore`

Configurar conexão com o banco de dados no arquivo `appsettings.json`


```
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=MinhaAppMvcCore;Trusted_Connection=True;"
  },
```

<br>

Executar no terminal `Package Manager Console (PM)`:
<br>

```
update-dabase --verbose
```

<br>

`Build >> Clean Solution`
<br>
`Build >> Build Solution`

<br>

![alt text](https://github.com/cleberspirlandeli/versionamento-api/blob/master/images/swagger.png)

<br>

![alt text](https://github.com/cleberspirlandeli/versionamento-api/blob/master/images/elmah.png)

<br>
