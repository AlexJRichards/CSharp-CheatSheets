# 03. Models

## What is a model?

A model is a C# class that represents data used by your application. In EF Core, a model is often mapped to a database table.

## Contact model example

```csharp
public class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
```

## Why the `Id` is important

The `Id` is commonly the primary key. It uniquely identifies each contact so the API can find, update, or delete the correct row.

## Model vs DTO

A model represents application or database data.
A DTO represents the data shape you want to accept or return at the API boundary.

For learning, this model is intentionally simple and easy to copy into a real project.
