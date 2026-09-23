# 01. Overview

## What is a Web API?

A Web API is a program that listens for HTTP requests and sends back HTTP responses, usually as JSON. A frontend app, mobile app, browser, or Swagger UI can call it.

## What is ASP.NET Core?

ASP.NET Core is Microsoft's framework for building web apps and APIs in C#. In this learning repo, it provides the controller system, routing, dependency injection, and JSON responses.

## What does EF Core do?

Entity Framework Core (EF Core) is an object-relational mapper (ORM). It lets you work with C# classes such as `Contact` while EF Core handles reading and writing database rows.

## What is SQLite?

SQLite is a small file-based database. It is useful for learning because you do not need a separate database server to get started.

## What is Swagger?

Swagger, also called OpenAPI tooling, gives you a web page where you can inspect endpoints and send test requests. It is helpful when you want to try `GET`, `POST`, `PUT`, and `DELETE` without building a frontend first.

## How the contact app fits together

A simple contact API might work like this:

1. Swagger or another client sends a request.
2. A controller action receives the request.
3. A request DTO holds incoming data.
4. The DTO is mapped to a `Contact` model.
5. `ContactsDbContext` uses EF Core to talk to SQLite.
6. The API sends a JSON response DTO back.

```text
Client/Swagger -> Controller -> DTO -> Model -> DbContext -> SQLite -> JSON response
```

This repo is documentation-first, so the goal is to explain the pieces clearly instead of shipping a runnable app.
