using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentation.Data.Entities;

public class AddressInfoEntity
{
    [Key] 
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    [ForeignKey(nameof(Profile))]
    public string UserId { get; set; } = null!;
    public ProfileEntity Profile { get; set; } = null!;

    [ForeignKey(nameof(AddressType))]
    public int AddressTypeId { get; set; }
    public AddressTypeEntity AddressType { get; set; } = null!;

    [Column(TypeName = "varchar(100)")]
    public string StreetName { get; set; } = null!;
    [Column(TypeName = "varchar(20)")]
    public string? StreetNumber { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string PostalCode { get; set; } = null!;
    [Column(TypeName = "varchar(100)")]
    public string City { get; set; } = null!;
    [Column(TypeName = "varchar(50)")]
    public string County { get; set; } = null!;
    [Column(TypeName = "varchar(50)")]
    public string Country { get; set; } = null!;
}