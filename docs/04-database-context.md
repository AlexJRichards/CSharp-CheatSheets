# 04. Database Context

## What is `DbContext`?

`DbContext` is the main EF Core class that manages database access. It tracks entities, runs queries, and saves changes.

## What does `DbSet<Contact>` do?

`DbSet<Contact>` represents the collection of `Contact` rows in the database. You query and update contacts through this property.

## How a table maps to a model

In a simple setup, EF Core can map the `Contact` model to a `Contacts` table. Each object becomes a row, and each property becomes a column.

## How dependency injection is used

ASP.NET Core creates `ContactsDbContext` through dependency injection. That lets controllers request the context in their constructor instead of building it manually.

```csharp
public class ContactsDbContext : DbContext
{
    public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }
}
```
