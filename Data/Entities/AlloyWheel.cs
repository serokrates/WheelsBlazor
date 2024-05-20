using System.ComponentModel.DataAnnotations;

namespace WheelsBlazor.Data.Entities
{
    public class AlloyWheel
    {
        [Key]
        public int Id { get; set; }
        public float Diameter { get; set; }
        public int BoltCircle { get; set; }
        public float Offset { get; set; }
    }
}
