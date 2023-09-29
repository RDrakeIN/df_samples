using System.ComponentModel.DataAnnotations;
namespace df_samples.Models;

public class Sample
{
    [Key]
    public int SampID { get; set; }

    [Required]
    [MaxLength(100)]
    public int ItemID { get; set; }
    public Item Item { get; set; }
    public int FactoryID { get; set; }
    public int CustID { get; set; }
    public int TypeID { get; set; }
    public DateOnly? Start_Date { get; set; }
    public int? QTY { get; set; }
    public string? SampFN { get; set; }
    public string? SampUP { get; set; }
    public string? SampN { get; set; }
    public DateOnly? WWDue_Date { get; set; }
    public DateOnly? FNDue_Date { get; set; }
    public DateOnly? UPDue_Date { get; set; }
    public DateOnly? MiscDue_Date { get; set; }
    public DateOnly? WWDone_Date { get; set; }
    public DateOnly? FNDone_Date { get; set; }
    public DateOnly? UPDone_Date { get; set; }
    public DateOnly? MiscDone_Date { get; set; }
    public string? StatusNotes { get; set; }
    public DateOnly? Completed_Date { get; set; }


    
}