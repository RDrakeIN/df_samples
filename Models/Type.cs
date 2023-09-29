using System.ComponentModel.DataAnnotations;
namespace df_samples.Models;

public class SampleType
{
    [Key]
    public int TypeID { get; set; }

    [Required]
    [MaxLength(100)]
    public string? TypeName { get; set; }
    
}