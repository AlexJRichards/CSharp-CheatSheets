# 02. Project Structure

## Example folder layout

```text
ContactInfo/
├── Models/
│   └── Contact.cs
├── Data/
│   └── ContactsDbContext.cs
├── Dtos/
│   └── ContactDtos.cs
├── Controllers/
│   └── ContactsController.cs
├── Program.cs
├── appsettings.json
├── ContactInfo.csproj
└── README.md
```

## What each part does

### `Models/`
Stores entity classes such as `Contact`. These classes describe the shape of data your app works with.

### `Data/`
Stores the EF Core database context. This is where `DbSet<Contact>` is defined.

### `Dtos/`
Stores request and response DTOs. DTOs help control what data enters and leaves your API.

### `Controllers/`
Stores API controller classes. A controller contains endpoint actions such as `GetContacts`, `PostContact`, and `DeleteContact`.

### `Program.cs`
Configures services, database registration, Swagger, and middleware.

### `appsettings.json`
Usually stores configuration values such as the database connection string.

### `ContactInfo.csproj`
The project file for the .NET application. It defines package references and the target framework.

### `README.md`
Explains the project and helps other people understand how to use or learn from it.

## Why structure matters

A consistent structure makes it easier to find files, understand responsibilities, and scale from a small learning project to a larger real-world API.
