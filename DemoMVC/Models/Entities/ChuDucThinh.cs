using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entities
{
    public class ChuDucThinh
    {
        [Key]
        public string FullName { get; set; }

        public string Address { get; set; }

        public string MSV { get; set; }
    }
}
