# BancoMVC
## Curso C# BancoMVC 



## CheckList

   
### Instalação para esse curso

.NET Core 2.1. Segue link
https://dotnet.microsoft.com/download/dotnet-core/2.1

MySQL Workbench Segue link
https://www.mysql.com/products/workbench/


 
### 1 - Criando Novo Projeto no VS

Selecionar modelo: Aplicativo Web do ASP.NET Core (Model-ViewController)

Selecionar .NET Core 2.1

*Iniciar projeto Ctrl + F5z

 
### 2 -  Organizar projeto - pasta Model (mover porque não é uma entidade do projeto, é um modelo auxiliar das telas)

Botão direto pasta Model, adicionar nova pasta nome "ViewModels" e mover ErrorViewModel.cs para esta pasta.

Corrigir no ErrorViewModel.cs o namespace para "namespace BancoMVC.Models.ViewModels"

Corrigir Views>Sharedd> no Error.cshtml na linha 1 "@model BancoMVC.Models.ViewModels.ErrorViewModel"

Corrigor Controllers> no HomeController.cs o "using BancoMVC.Models.ViewModels;"

Compilar solução - Ctrl + Shit + B 


### 3 - Criar classes entidades

Botão direito na pasta Model e criar classe (Exemplo Clientes)

Criar as propriedades da classe

*Compilar solução - Ctrl + Shit + B

 
### 4 - Adicionar Scaffolded Item

Botão direito na pasta Controllers, adicionar, adicionar novo item scaffold.

Escolher Commum>MVC> "Controlador MVC com exibições, usando Entity Framework" e clicar em adicionar. 

Escolher Classe modelo (exemplo clientes), criar classe de contexto de dados no botão "+" e clicar e adicionar.

*Compilar solução - Ctrl + Shit + B 

 
### 5 - Adaptação para MySql 

Corrigir no appsettings.json a string de conexão em "BancoMVCContext": "server=localhost;userid=suporte;port=4569;password=suporte;database=bancomvc"

No método ConfigureServices:

Corrigir no Startup.cs, no método ConfigureServices, a operação:

De:

	options.UseSqlServer(Configuration.GetConnectionString("BancoMVCContext")));
	
Para:

	options.UseMySql(Configuration.GetConnectionString("BancoMVCContext"), builder =>
	builder.MigrationsAssembly("BancoMVC")));
	
	
Para adicionar provider MySql, abrir o terminal do NuGet, Ferramentas> Gerenciador de Pacotes do NuGet> Console do Gerenciador de Pacotes, digitar:

	Install-Package Pomelo.EntityFrameworkCore.MySql -Version 2.1.1
	
*Compilar solução - Ctrl + Shit + B 

 
### 6 - Gerar a Migration para a base de dados com base na classe

Cria o script que cria a base

Abrir o terminal do NuGet, Ferramentas, Gerenciador de Pacotes do NuGet, Console do Gerenciador de Pacotes, digitar:

Add-Migration Initial

Executar o script

Abrir o terminal do NuGet, Ferramentas, Gerenciador de Pacotes do NuGet, Console do Gerenciador de Pacotes, digitar:

Update-Database

*Iniciar projeto Ctrl + F5


