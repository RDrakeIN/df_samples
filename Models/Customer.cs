using System.ComponentModel.DataAnnotations;
namespace df_samples.Models;

public class Customer
{
    [Key]
    public int CustID { get; set; }

    [Required]
    [MaxLength(100)]
    public string? CustName { get; set; }
    
}