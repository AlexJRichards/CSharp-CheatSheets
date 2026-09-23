# ContactInfoWiki

A beginner-friendly wiki and reference guide for learning how an ASP.NET Core Web API fits together with Entity Framework Core, SQLite, DTOs, controllers, and Swagger.

> [!IMPORTANT]
> This repository is a learning and reference wiki. It is **not** a runnable or production-ready application.

## What this repo is for

This repo teaches the moving parts of a simple contact-management API by using short explanations and small code examples you can copy into a real .NET project.

You can use it to learn:
- what a Web API is
- how ASP.NET Core handles requests and responses
- how Entity Framework Core talks to SQLite
- why DTOs are useful
- how controllers and endpoints are organized
- how CRUD patterns work in a beginner-friendly API
- how Swagger helps you test API endpoints
- how migrations update a database schema

## Quick beginner overview

- **ASP.NET Core**: the framework used to build the Web API.
- **EF Core**: the data-access library that maps C# classes to database tables.
- **SQLite**: a lightweight database stored in a local file.
- **DTOs**: simple classes used to shape request and response data.
- **Swagger**: a browser-based UI for exploring and testing API endpoints.

## Learning path

1. Start with the [overview](docs/01-overview.md)
2. Review the [project structure](docs/02-project-structure.md)
3. Learn the [model](docs/03-models.md) and [DbContext](docs/04-database-context.md)
4. See [Program.cs configuration](docs/05-program-configuration.md)
5. Understand [controllers](docs/06-controllers.md) and [CRUD endpoints](docs/07-crud-endpoints.md)
6. Learn why [DTOs](docs/08-dtos.md) matter
7. Review [EF Core basics](docs/09-entity-framework.md), [Swagger](docs/10-swagger.md), [validation](docs/11-validation.md), and [migrations](docs/12-migrations.md)
8. Use [troubleshooting](docs/13-troubleshooting.md) and the [cheat sheet](docs/14-cheat-sheet.md) as quick references

## Topics covered

- Models
- DbContext
- Controllers
- Endpoints
- Requests and responses
- DTOs
- Dependency injection
- Connection strings
- CRUD operations
- Entity Framework Core queries and updates
- Swagger testing
- Validation attributes
- Migrations
- Common beginner mistakes

## Documentation index

- [01 - Overview](docs/01-overview.md)
- [02 - Project Structure](docs/02-project-structure.md)
- [03 - Models](docs/03-models.md)
- [04 - Database Context](docs/04-database-context.md)
- [05 - Program Configuration](docs/05-program-configuration.md)
- [06 - Controllers](docs/06-controllers.md)
- [07 - CRUD Endpoints](docs/07-crud-endpoints.md)
- [08 - DTOs](docs/08-dtos.md)
- [09 - Entity Framework Core](docs/09-entity-framework.md)
- [10 - Swagger](docs/10-swagger.md)
- [11 - Validation](docs/11-validation.md)
- [12 - Migrations](docs/12-migrations.md)
- [13 - Troubleshooting](docs/13-troubleshooting.md)
- [14 - Cheat Sheet](docs/14-cheat-sheet.md)
- [Glossary](glossary.md)
- [Examples README](examples/README.md)
- [API Flow Diagram](diagrams/api-flow.md)

## Beginner-friendly terminology

- **Model**: the C# class that represents your app's data.
- **DbContext**: the EF Core class that connects your app to the database.
- **DTO**: a class used to send or receive only the data your API needs.
- **Controller**: the class that contains API actions.
- **Endpoint**: one URL + HTTP method combination, such as `GET /api/contacts`.
- **Request**: data sent to the API.
- **Response**: data sent back from the API.
- **Migration**: a tracked database schema change.
- **Connection string**: the setting that tells the app how to find the database.

## Useful starting points

- Read the full [request flow](diagrams/api-flow.md)
- Compare a [model and DTO](docs/08-dtos.md)
- Copy the example [controller](examples/Controllers/ContactsController.cs)
- Use the [cheat sheet](docs/14-cheat-sheet.md) for quick reminders

For learning, the examples are intentionally simple so that the main API ideas are easy to follow.
