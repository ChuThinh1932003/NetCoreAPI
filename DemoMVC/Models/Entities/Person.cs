using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entities
{
    public class Person
    {
        [Key]
        [Required]
        public string PersonID { get; set;}
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FullName { get; set; }

        public string? Address { get; set; }
        
    }
}