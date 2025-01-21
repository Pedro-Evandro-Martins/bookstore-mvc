using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookstoreMvc.Models;

public class Category
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [DisplayName("Category Name")]
    public string Name { get; set; }
    
    [Required]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
}