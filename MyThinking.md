# My Thought Process

Web Application : MVC Application
Data Base       : In Memory SQL Server (DotDatabase)
Data Access ORM : EntityFramework
Data Mapping    : Via Auto Mapper
CI              : GitHub Workflows
CD              : Azure 

# Technical description

This project uses the MVC(Model-Based View) architecture design patterns, repository pattern, unit of work, singleton pattern and dependency injection to achieve functionality.

> The project uses Web Layer architecture:
    -  Presentation layer
    -  Business layer
    -  DataAccess layer

The application uses InMemory database to allow rapid prototyping and data storage. 

When the application fires up, the app attempts to contact the following GitHub api https://api.github.com/users - automatic! for users to seed the database. Upon success a list of users are retreived, each user may or may not have a list of followers.

	To demonstrate fetching large datasets, the app also navigates to each follower user and extracts the login id to be stored with each user in addition to some the user's own properties.
	
The search feature utilizes this method via the api https://api.github.com/search/users?q= - automatic! to fetch users whose login id matches the query.

The landing page list the users in the database, the search results are also displayed using the same view to maximize reuse. 

The search results allow the user to add a new user to the database. Users in the application can be marked as favorites too.

Since the github api limits each IP address to a maximum of 5000 requests per hour https://docs.github.com/en/developers/apps/building-github-apps/rate-limits-for-github-apps - automatic! , the user/developer has the option to toggle settings to mimic the online github api by reading sample user data from a file.

## Technologies used:

ASP.NET Core MVC (.NET 3.1), ASP.NET Core Razor Pages, Dependency Injection, Entity Framework Core,AutoMapper, InMemory database, CRUD Operations, NUnit tests, JQuery AJAX, Plain javascript, Responsive design, CI and CD using GitHub - Azure integrations.
