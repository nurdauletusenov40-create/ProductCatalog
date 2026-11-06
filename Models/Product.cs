using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Тауар атауын енгізіңіз.")]
    [StringLength(100, ErrorMessage = "Тауар атауы 100 таңбадан аспауы керек.")]
    [Display(Name = "Тауар атауы")]
    public string Name { get; set; } = string.Empty;

    [Range(typeof(decimal), "0.01", "1000000000", ErrorMessage = "Баға нөлден жоғары болуы керек.")]
    [Display(Name = "Бағасы")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Санатты таңдаңыз.")]
    [StringLength(60, ErrorMessage = "Санат атауы 60 таңбадан аспауы керек.")]
    [Display(Name = "Санаты")]
    public string Category { get; set; } = string.Empty;

    [Display(Name = "Қолжетімді")]
    public bool IsAvailable { get; set; }
}
