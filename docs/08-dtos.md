# 08. DTOs

## What is a DTO?

DTO stands for Data Transfer Object. A DTO is a class used to send or receive data through the API.

## When to use DTOs

Use DTOs when:
- you do not want to expose the full model
- request data is different from response data
- you want validation rules on input classes
- you want cleaner API contracts

## Why DTOs are valuable

DTOs help you control your API boundary. They make it easier to change the database model later without changing every client.

## Model vs DTO

- **Model**: represents application data and often maps to the database
- **DTO**: represents API input or output

## Example DTOs

```csharp
public class ContactResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

public class CreateContactRequest
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

public class UpdateContactRequest
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
```

## Before: returning the model directly

```csharp
[HttpGet("{id}")]
public async Task<ActionResult<Contact>> GetContact(int id)
{
    var contact = await _context.Contacts.FindAsync(id);

    if (contact is null)
    {
        return NotFound();
    }

    return contact;
}
```

## After: returning a response DTO

```csharp
[HttpGet("{id}")]
public async Task<ActionResult<ContactResponse>> GetContact(int id)
{
    var contact = await _context.Contacts.FindAsync(id);

    if (contact is null)
    {
        return NotFound();
    }

    var response = new ContactResponse
    {
        Id = contact.Id,
        FirstName = contact.FirstName,
        LastName = contact.LastName,
        Email = contact.Email,
        Phone = contact.Phone
    };

    return Ok(response);
}
```

## Mapping from request DTO to model

```csharp
var contact = new Contact
{
    FirstName = request.FirstName,
    LastName = request.LastName,
    Email = request.Email,
    Phone = request.Phone
};
```

## Why DTOs matter

DTOs may feel like extra work at first, but they make your API easier to understand, validate, and change safely.
