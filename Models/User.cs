using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [Range(1, 150)]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string Phone { get; set; }

    [Required]
    [StringLength(100)]
    public string AddressCountry { get; set; }

    [Required]
    [StringLength(100)]
    public string AddressCity { get; set; }

    [Required]
    [StringLength(150)]
    public string AddressStreetName { get; set; }
}
