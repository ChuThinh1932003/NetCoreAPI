using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models.Entities
{
    public class ChuDucThinh
    {
        [Key]
        public string ChuDucThinhID { get; set; }

        public string ChuDucThinhName { get; set; }
    }
}
