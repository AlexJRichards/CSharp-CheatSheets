# 09. Entity Framework Core

## What is EF Core?

EF Core is Microsoft's object-relational mapper for .NET. It helps you read and write database data with C# classes instead of hand-writing SQL for every operation.

## Common EF Core methods

### `SaveChangesAsync()`
Saves pending inserts, updates, and deletes to the database.

### `ToListAsync()`
Runs a query and returns the results as a list.

### `FindAsync()`
Looks up one entity, usually by primary key.

### `Add()`
Marks a new entity to be inserted when `SaveChangesAsync()` is called.

### `Remove()`
Marks an entity to be deleted when `SaveChangesAsync()` is called.

## What migrations are

A migration is a recorded schema change, such as creating a table or adding a new column. Migrations help keep the database structure in sync with your model classes.

## App model vs database table

A `Contact` model is a C# class inside your app. A `Contacts` table is the database structure where rows are stored. EF Core connects those two ideas.
