# 11. Validation

## What is server-side validation?

Server-side validation checks incoming data before your API saves or uses it. This protects your app from missing or invalid values.

## Common validation attributes

```csharp
[Required]
public string FirstName { get; set; } = "";

[EmailAddress]
public string? Email { get; set; }
```

## `ModelState`

`ModelState` stores validation results for incoming request data. In an API controller, `[ApiController]` can automatically return a `400 Bad Request` response when the request body is invalid.

## Validation on DTOs

Validation attributes are often placed on request DTOs instead of on database models. That keeps API rules focused on input data.

```csharp
public class CreateContactRequest
{
    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    [EmailAddress]
    public string? Email { get; set; }

    public string? Phone { get; set; }
}
```
