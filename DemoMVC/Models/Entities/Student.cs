using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentId { get; set; }

        public string FullName { get; set;}

        public string Address { get; set;}

    }
}