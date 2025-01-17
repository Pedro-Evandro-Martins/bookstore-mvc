using System.ComponentModel.DataAnnotations;

namespace BookstoreMvc.Models;

public class Category
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int DisplayOrder { get; set; }
}