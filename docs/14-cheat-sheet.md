# 14. Cheat Sheet

## Model example

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

## DbContext example

```csharp
public class ContactsDbContext : DbContext
{
    public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contact> Contacts => Set<Contact>();
}
```

## DTO example

```csharp
public class CreateContactRequest
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
```

## Controller route pattern

```csharp
[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
}
```

## CRUD snippet summary

```csharp
[HttpGet]              // GET /api/contacts
[HttpGet("{id}")]      // GET /api/contacts/1
[HttpPost]             // POST /api/contacts
[HttpPut("{id}")]      // PUT /api/contacts/1
[HttpDelete("{id}")]   // DELETE /api/contacts/1
```

## HTTP status codes

- `200 OK`
- `201 Created`
- `204 No Content`
- `400 Bad Request`
- `404 Not Found`

## Common commands

```powershell
Add-Migration InitialCreate
Update-Database
```
