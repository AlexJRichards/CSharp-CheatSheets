# 10. Swagger

## What is Swagger/OpenAPI?

Swagger is a tool that shows your API endpoints in a browser. It is built from an OpenAPI description and is very useful for learning because you can test endpoints without writing a frontend.

## How Swagger helps test API endpoints

You can use Swagger to:
- inspect available routes
- view request and response shapes
- send test requests
- see returned status codes

## Testing common endpoints

### Test GET
Open the `GET /api/contacts` endpoint and click **Try it out** to fetch all contacts.

### Test POST
Open `POST /api/contacts`, paste JSON, and send the request.

Example create payload:

```json
{
  "firstName": "Katherine",
  "lastName": "Johnson",
  "email": "katherine@example.com",
  "phone": "555-0104"
}
```

### Test PUT
Use `PUT /api/contacts/{id}` to update a contact by id.

### Test DELETE
Use `DELETE /api/contacts/{id}` to remove a contact.

For learning, Swagger is one of the easiest ways to see how requests and responses behave in a real API.
