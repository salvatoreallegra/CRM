using System.ComponentModel.DataAnnotations;

namespace CRM.Api.Models;

public class Customer
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [EmailAddress]
    [MaxLength(255)]
    public string? Email { get; set; }

    [Phone]
    [MaxLength(50)]
    public string? Phone { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}