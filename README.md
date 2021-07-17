# BancoMVC
Curso C# BancoMVC 

***

#CheckList
##1 - Criando Novo Projeto no VS
-Selecionar modelo: Aplicativo Web do ASP.NET Core (Model-ViewController)
*Iniciar projeto Ctrl + F5z
***

##2 -  Organizar projeto pasta Model
-Botão direto pasta Model, adicionar nova pasta nome "ViewModels" e mover ErrorViewModel.cs para esta pasta
-Corrigir no ErrorViewModel.cs o namespace para "namespace BancoMVC.Models.ViewModels"
-Corrigir no Error.cshtml na linha 1 "@model BancoMVC.Models.ViewModels.ErrorViewModel"
-Corrigor no HomeController.cs o "using BancoMVC.Models.ViewModels;"
*Compilar solução - Ctrl + Shit + B 
***

##3 - Criar classes entidades
-Botão direito na pasta Model e criar classe (Exemplo Clientes)
-Criar as propriedades da classe
*Compilar solução - Ctrl + Shit + B
*** 

##4 - Adicionar Scaffolded Item
-Botão direito na pasta Controllers, adicionar, adicionar novo item scaffold,
escolher "Controlador MVC com exibições, usando Entity Framework", clicar em adicionar,
escolher Classe modelo (exemplo clientes),
criar classe de contexto de dados no botão "+", e clicar e adicionar
*Compilar solução - Ctrl + Shit + B 
***

##5 - Adaptação para MySql 
-Corrigir no appsettings.json a string de conexão em "BancoMVCContext": "server=localhost;userid=suporte;port=4569;password=suporte;database=bancomvc"
-Corrigir no Startup.cs, no método ConfigureServices, a operação: 
	options.UseSqlServer(Configuration.GetConnectionString("BancoMVCContext")));
para:
	options.UseSqlServer(Configuration.GetConnectionString("BancoMVCContext"), builder =>
	builder.MigrationsAssembly("BancoMVC")));	
-Para adicionar provider MySql, abrir o terminal do NuGet, Ferramentas, Gerenciador de Pacotes do NuGet, Console do Gerenciador de Pacotes, digitar:  
	Install-Package Pomelo.EntityFrameworkCore.MySql -Version 2.1.1
*Compilar solução - Ctrl + Shit + B 
***

##6 - Gerar a Migration para a base de dados com base na classe
###6.1 Cria o script que cria a base
	Abrir o terminal do NuGet, Ferramentas, Gerenciador de Pacotes do NuGet, Console do Gerenciador de Pacotes, digitar:
	Add-Migration Initial
###6.2 Executa o script
	Abrir o terminal do NuGet, Ferramentas, Gerenciador de Pacotes do NuGet, Console do Gerenciador de Pacotes, digitar:
	Update-Database
*Iniciar projeto Ctrl + F5
***
