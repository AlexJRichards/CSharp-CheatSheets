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
public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
{
    return await _context.Contacts.ToListAsync();
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
public async Task<ActionResult<Contact>> PostContact(Contact contact)
{
    _context.Contacts.Add(contact);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
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
public async Task<IActionResult> PutContact(int id, Contact contact)
{
    if (id != contact.Id)
    {
        return BadRequest();
    }

    var existingContact = await _context.Contacts.FindAsync(id);
    if (existingContact is null)
    {
        return NotFound();
    }

    existingContact.FirstName = contact.FirstName;
    existingContact.LastName = contact.LastName;
    existingContact.Email = contact.Email;
    existingContact.Phone = contact.Phone;

    await _context.SaveChangesAsync();
    return NoContent();
}
```

Example response JSON:

```json
null
```

`204 No Content` means the update succeeded and the API does not send a JSON body back.

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

Example response JSON:

```json
null
```

`204 No Content` means the delete succeeded and the API does not send a JSON body back.

For learning, these examples stay small so the request/response patterns are easy to see.
