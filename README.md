[![.NET](https://github.com/Prigan/dotnet-webapp-deepti/actions/workflows/Basic%20CI%20and%20CD.yml/badge.svg)](https://github.com/Prigan/dotnet-webapp-deepti/actions/workflows/Basic%20CI%20and%20CD.yml)

# DöT - GitHub developer search app

A user friendly application that allows anyone to search for git users by their username and add/remove them as favorites.
An offline mode for the application is also available. 
The application integrates into the github workflow by establishing a CI and CD pipeline and is hosted on Microsoft Azure websites, accessible at https://pgdotapp.azurewebsites.net/

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

## Requirements to develop

- Visual studio 2019 for web development
- .NET Core 3.1 SDK
- Azure Account for Deployment
- Valid and available github requests limit for your IP address

## Configureation Instructions

To Run Locally: 

Since the code uses InMemory DB , just download the code and run

For CD:

Modify the publish profile to your publish profile in the .yml file 


### Tools used:

	- Microsoft Visual Studio 2019 IDE
	- Git Bash
	- GitHub Desktop
	- Code formatting using Code Maid
	- VisualStudio Code

# Settings

```
Inside appsettings.json
------------------------

IsLive : true/false

```

# Known issues

1. When the application is deployed or run using the 
---
IsLive : true
---
setting, the landing page may display the message 
> No users loaded, please try again later.
This happens when the github api rate limit is exceeded or when there is an error fetching data.

1. When the application is deployed or run using the 
---
IsLive : false
--- 
new searches may not fetch data if the rate limit is exceeded.
	
# How to launch the project 

Review the settings 
Press Ctrl+F5

# Things I would do if I had more time

- Introduce a worker service to perform recursive data fetching from github
- Convert to a Angular based SPA application
- Lazy loading of users
- Use Azure SQL Server instead of InMemorySQL
