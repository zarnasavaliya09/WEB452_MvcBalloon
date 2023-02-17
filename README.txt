# Assignment 1
	Author name:Zarna Savaliya
	Date:2023-02-16 1254EST
	Project:MvcBalloons
	Purpose: Create Mvc Application using .NET framework core 3.1

	#create project
	create a ASP.NET webapplication using MVC
	create new repository WEB452_MvcBalloons in github and commit changes
	create README.txt in visual studio 2019

	0309EST
	now ,its a time to change title of project to Up and Away Ballons.
	next, add new controller named BalloonsController.cs
	it's a time to create a view,so i create new folder named HelloWorld and add index.cshtml file.
	add another navigation link About Us to Nav Menu and create view AboutUs.cshtml file.
	Update footer to product name.

	0428EST
	Let's make Data model class Balloon.cs
	in model class i added six attribute category,occassion,color,size,shape,price and rating with its appropriate datatype.
	Then Add NuGet Package Manager inside package manager console
	and run the command Install-Package Microsoft.EntityFrameworkCore.SqlServer
	ohh.. i get an error Package Microsoft.EntityFrameworkCore.SqlServer 7.0.3 is not compatible with netcoreapp 3.1
	it's take too much time i think i have to move to next step.

	0542EST
	create database context class need to add CRUD operations for a Balloon model which extends DbContext
	create Dbset property for the entity set.
	next..add entity frameworkcore in top of startup.cs.
	the name of the connection string is alredy in configurationservices.
	Add connection string in appsettings.json file.

	0945EST
	Now,move forward to scaffolding tool to create,read,update,delete pages for balloon model.
	no...i get an error :no parameterless constructor defined for type while scafolding.
	so i again throughout the code , i found that i fprgot to add DBContext in ConfigurationServices method.












