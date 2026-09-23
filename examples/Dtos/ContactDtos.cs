using System.ComponentModel.DataAnnotations;

namespace ContactInfoWiki.Dtos;

public class ContactResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

public class CreateContactRequest
{
    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    [EmailAddress]
    public string? Email { get; set; }

    public string? Phone { get; set; }
}

public class UpdateContactRequest
{
    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    [EmailAddress]
    public string? Email { get; set; }

    public string? Phone { get; set; }
}
