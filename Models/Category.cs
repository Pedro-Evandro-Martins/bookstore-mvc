using System.ComponentModel.DataAnnotations;

namespace BookstoreMvc.Models;

public class Category
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int DisplayOrder { get; set; }
}