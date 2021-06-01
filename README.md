### Base Backend
# Estrutura elaborada para resolver problemas complexos utilizando o design DDD com versionamento de Endpoints


### DDD 
É uma abordagem de modelagem de software que segue um conjunto de práticas com objetivo de facilitar a implementação de complexas regras / processos de negócios que tratamos como domínio.
<br>
Domain Driven Design como o nome já diz é sobre design. Design guiado pelo domínio, ou seja, uma modelagem de software focada em resolver problemas na complexidade do negócio.
<br>
“Toda arquitetura é design, mas nem todo design é arquitetura” – Grady Booch
<br>
O DDD não é uma receita pronta sobre como desenvolver uma arquitetura baseada em Presentation, Services, Application, Domain e Infra.
<br>
Fonte: [`Eduardo Pires`](https://www.eduardopires.net.br/2016/08/ddd-nao-e-arquitetura-em-camadas/)
<br>
<br/>

Objetivo:
- Criar uma estrutura base, separando responsabilidades com fundamentos no design DDD.
- Realizar versionamento de `endpoints`
- Retorno padronizado e inclusive erros
- Erros gerados serão incluidos em uma lista ao em vez de gerar um `New Error` - (Exception Patterns)
- Documentação da API utilizando `Swagger`
- Utilizar AutoMapper
- Validação de regras de negocio, classes e DTO's com FluentValidation
- Autenticação com `JWT`
- Implementar `ASP.NET Identity` com permissões de acesso com `Claims` e `Roles`
- Captação de informações para monitoramento da API utilizando `Prometheus`
- Conversão de 3.1 para 5.x
- TODO - Implementar Interfaces (record .NET5)
- TODO - Implementar Testes automatizados
- TODO - Integração com outra API utilizando HTTP
- TODO - Integração com outra API utilizando RabittMQ
- TODO - Apresentação das informações de monitoramento em gráficos com `Grafana`
- TODO - Implementar Ambiente Docker
- TODO - Subir aplicação no `IIS local` e no `Azure`

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

Executar no terminal `Package Manager Console (PM)` no projeto `Infrastructure`:
<br>

```
update-dabase -Context DefaultDataBaseContext --verbose
```
```
update-dabase -Context DefaultIdentityDbContext --verbose
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
