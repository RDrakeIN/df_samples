using System.ComponentModel.DataAnnotations;
namespace df_samples.Models;

public class Factory
{
    [Key]
    public int FactoryID { get; set; }

    [Required]
    [MaxLength(100)]
    public string? FactoryName { get; set; }
    public string? FactoryRegion { get; set; }
    
}