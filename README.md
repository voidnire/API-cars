CRIANDO API - PASSOS

 1 - classe p/ declarar os atributos

 2 - pacotes: //usei os 5.0.10
	EF core
	EF core tools
	EF sql serveR

 3 - colocar a connection strings no appsettings.json
ex: "ConnectionStrings": {
    "ApiConnectionString": "Server=.\\SQLEXPRESS;Database=NomeDoDatabase;Trusted_Connection=yes;"//string ta certa 
  }
//em baixo do allowedhosts

 4 - cria class do dbcontext q vai herdar da class 	EF 'DbContext' // lembrar de construir classe

 5 - configurar o context na classe startup
ex: services.AddDbContext<Nomedaclassecontext>(2E-DESK18\SQLEXPRESS

 6 - abrir o SQL Server Management Studio, criar database (eh bom criar antes pra por o nome na connection string), apertar na tomadinha pra conectar

 7- abrir no vs o package manager console e fazer a migraçao com os comandos 
 Add-Migration //ela vai construir uma classe que se refere à table criada no database
 Update-Database

 8 - criar controller //eh onde fica os metodos de post e get, aí cria os dois


- dica for later: scaffold //cria controle automaticament com todos os metodos, ver em https://www.youtube.com/watch?v=oPGhzIrYQXQ minuto 20:25

	
	EXTRAS:
	site legal: https://http.cat
	
