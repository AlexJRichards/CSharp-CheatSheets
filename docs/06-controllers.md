# 06. Controllers

## What is a controller?

A controller is a class that groups related API endpoints. In a contact API, `ContactsController` usually handles create, read, update, and delete actions.

## Route attributes

Route attributes define the URL pattern for the controller or action.

- `[Route("api/[controller]")]` means the base route is built from the controller name.
- For `ContactsController`, that becomes `api/contacts`.

## `[ApiController]`

`[ApiController]` enables API-friendly behavior such as automatic validation responses and clearer binding rules.

## `ControllerBase`

`ControllerBase` gives you useful API methods such as `Ok()`, `NotFound()`, `CreatedAtAction()`, and `NoContent()`.

## Dependency injection of `DbContext`

The controller receives `ContactsDbContext` through its constructor so it can query and save contacts.

```csharp
[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly ContactsDbContext _context;

    public ContactsController(ContactsDbContext context)
    {
        _context = context;
    }
}
```
