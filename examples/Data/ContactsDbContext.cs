using ContactInfoWiki.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactInfoWiki.Data;

public class ContactsDbContext : DbContext
{
    public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contact> Contacts => Set<Contact>();
}
