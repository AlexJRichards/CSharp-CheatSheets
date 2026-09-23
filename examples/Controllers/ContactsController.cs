using ContactInfoWiki.Data;
using ContactInfoWiki.Dtos;
using ContactInfoWiki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactInfoWiki.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly ContactsDbContext _context;

    public ContactsController(ContactsDbContext context)
    {
        _context = context;
    }

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

    [HttpGet("{id}")]
    public async Task<ActionResult<ContactResponse>> GetContact(int id)
    {
        var contact = await _context.Contacts.FindAsync(id);
        if (contact is null)
        {
            return NotFound();
        }

        return Ok(MapToResponse(contact));
    }

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

        var response = MapToResponse(contact);
        return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, response);
    }

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

    private static ContactResponse MapToResponse(Contact contact)
    {
        return new ContactResponse
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Email = contact.Email,
            Phone = contact.Phone
        };
    }
}
