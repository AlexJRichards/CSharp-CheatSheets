# 13. Troubleshooting

## Unable to find project

Make sure your terminal is open in the project folder that contains the `.csproj` file.

## No migration found

Check that you created a migration first and that you are using the correct startup project and working directory.

## Database table missing

This often means migrations were not applied or the app is pointing to a different SQLite file than you expected.

## Wrong working directory

If commands fail, confirm you are in the folder that contains `Program.cs` and the project file.

## Route mismatch

If `/api/contacts` does not work, check the controller route attributes and make sure the request URL matches them.

## Wrong controller name

If you rename `ContactsController`, the `[controller]` token in the route also changes.

## Swagger not loading

Check that Swagger services and middleware were added in `Program.cs`.

## Database not updating

Make sure `SaveChangesAsync()` is being called after add, update, or delete operations.

## Path or namespace mix-ups

When files move between folders such as `Models`, `Dtos`, and `Data`, update the namespaces and `using` statements to match.
