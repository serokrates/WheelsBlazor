using System.ComponentModel.DataAnnotations;

namespace WheelsBlazor.Data.Entities
{
    public class WheelsTable
    {
        [Key]
        public int ID { get; set; }
        public int BrandID { get; set; }
        public string? BrandType { get; set; }
    }
}
