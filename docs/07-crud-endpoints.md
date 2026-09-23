# 07. CRUD Endpoints

CRUD means Create, Read, Update, and Delete.

## GET all contacts

- **Route**: `/api/contacts`
- **Method**: `GET`
- **Purpose**: returns every contact
- **Example request JSON**: no request body is needed for this endpoint
- **Status codes**: `200 OK`

```csharp
[HttpGet]
public async Task<ActionResult<IEnumerable<ContactResponse>>> GetContacts()
{
    var contacts = await _context.Contacts
        .Select(contact => new ContactResponse
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Email = contact.Email,
            Phone = contact.Phone
        })
        .ToListAsync();

    return Ok(contacts);
}
```

Example response JSON:

```json
[
  {
    "id": 1,
    "firstName": "Ada",
    "lastName": "Lovelace",
    "email": "ada@example.com",
    "phone": "555-0101"
  }
]
```

## GET contact by ID

- **Route**: `/api/contacts/{id}`
- **Method**: `GET`
- **Purpose**: returns one contact
- **Example request JSON**: no request body is needed for this endpoint
- **Status codes**: `200 OK`, `404 Not Found`

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

Example response JSON:

```json
{
  "id": 1,
  "firstName": "Ada",
  "lastName": "Lovelace",
  "email": "ada@example.com",
  "phone": "555-0101"
}
```

## POST contact

- **Route**: `/api/contacts`
- **Method**: `POST`
- **Purpose**: creates a new contact
- **Example request JSON**: create data for a new contact
- **Status codes**: `201 Created`, `400 Bad Request`

Example request JSON:

```json
{
  "firstName": "Grace",
  "lastName": "Hopper",
  "email": "grace@example.com",
  "phone": "555-0102"
}
```

```csharp
[HttpPost]
public async Task<ActionResult<ContactResponse>> PostContact(CreateContactRequest request)
{
    var contact = new Contact
    {
        FirstName = request.FirstName,
        LastName = request.LastName,
        Email = request.Email,
        Phone = request.Phone
    };

    _context.Contacts.Add(contact);
    await _context.SaveChangesAsync();

    var response = new ContactResponse
    {
        Id = contact.Id,
        FirstName = contact.FirstName,
        LastName = contact.LastName,
        Email = contact.Email,
        Phone = contact.Phone
    };

    return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, response);
}
```

Example response JSON:

```json
{
  "id": 2,
  "firstName": "Grace",
  "lastName": "Hopper",
  "email": "grace@example.com",
  "phone": "555-0102"
}
```

## PUT contact

- **Route**: `/api/contacts/{id}`
- **Method**: `PUT`
- **Purpose**: updates an existing contact
- **Example request JSON**: replacement data for the contact
- **Status codes**: `204 No Content`, `400 Bad Request`, `404 Not Found`

Example request JSON:

```json
{
  "firstName": "Grace",
  "lastName": "Hopper",
  "email": "grace.hopper@example.com",
  "phone": "555-0103"
}
```

```csharp
[HttpPut("{id}")]
public async Task<IActionResult> PutContact(int id, UpdateContactRequest request)
{
    var contact = await _context.Contacts.FindAsync(id);
    if (contact is null)
    {
        return NotFound();
    }

    contact.FirstName = request.FirstName;
    contact.LastName = request.LastName;
    contact.Email = request.Email;
    contact.Phone = request.Phone;

    await _context.SaveChangesAsync();
    return NoContent();
}
```

Example response:

No response body is returned for `204 No Content`.

## DELETE contact

- **Route**: `/api/contacts/{id}`
- **Method**: `DELETE`
- **Purpose**: removes an existing contact
- **Example request JSON**: no request body is needed for this endpoint
- **Status codes**: `204 No Content`, `404 Not Found`

```csharp
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteContact(int id)
{
    var contact = await _context.Contacts.FindAsync(id);
    if (contact is null)
    {
        return NotFound();
    }

    _context.Contacts.Remove(contact);
    await _context.SaveChangesAsync();

    return NoContent();
}
```

Example response:

No response body is returned for `204 No Content`.

For learning, these examples stay small so the request/response patterns are easy to see.
