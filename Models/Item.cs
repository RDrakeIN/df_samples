using System.ComponentModel.DataAnnotations;
namespace df_samples.Models;

public class Item
{
    [Key]
    public int ItemID { get; set; }

    [Required]
    [MaxLength(100)]
    public string? ItemNum { get; set; }

    public string? ItemName { get; set; }
    
}