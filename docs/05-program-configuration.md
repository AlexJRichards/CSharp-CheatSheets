# 05. Program Configuration

## What `Program.cs` does

In a minimal ASP.NET Core app, `Program.cs` is the startup file. It creates the app builder, registers services, and configures middleware.

## Dependency injection

Dependency injection means ASP.NET Core creates shared services for you. When you register `ContactsDbContext`, controllers can ask for it in their constructor.

## SQLite registration

You typically register the database context like this:

```csharp
builder.Services.AddDbContext<ContactsDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("ContactsDb")));
```

## Connection strings

A connection string tells the app where the database is located.

Example `appsettings.json` value:

```json
{
  "ConnectionStrings": {
    "ContactsDb": "Data Source=contacts.db"
  }
}
```

## Why `GetConnectionString("ContactsDb")` matters

`builder.Configuration.GetConnectionString("ContactsDb")` reads the named value from configuration so your database location is not hard-coded all over the app.
