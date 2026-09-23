# API Flow Diagram

## Request and response flow

```text
Swagger / client
  -> HTTP request
  -> Controller
  -> DTO mapping
  -> Model / DbContext
  -> SQLite database
  -> Response JSON
```

## Visual explanation

### Model vs DTO

```text
DTO = API boundary data
  - shapes request and response bodies
  - used for validation and safer contracts

Model = application/database data
  - represents a Contact entity
  - mapped by EF Core to a database table
```

### API boundary vs database boundary

```text
Client JSON
  -> Request DTO
  -> Controller logic
  -> Contact model
  -> DbContext / EF Core
  -> SQLite table rows
```
