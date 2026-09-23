# 12. Migrations

## What is a migration?

A migration is a saved description of a database schema change. EF Core uses migrations so you can evolve your database as your models change.

## Common commands

```powershell
Add-Migration InitialCreate
Update-Database
```

## What these commands do

- `Add-Migration InitialCreate` creates a migration based on your current models.
- `Update-Database` applies pending migrations to the database.

## What the database file is

With SQLite, your data is commonly stored in a local file such as `contacts.db`.

## Resetting the local database while learning

When practicing, you might delete the SQLite database file and old migrations, then recreate the migration and database. That can be a simple way to start over while learning, even though production projects need more care.
