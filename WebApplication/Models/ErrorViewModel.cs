using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models;

public class ErrorViewModel
{
    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [Phone]
    public required string Phone { get; set; }

    public string? Company { get; set; }
}
