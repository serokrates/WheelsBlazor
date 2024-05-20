namespace WheelsBlazor.Data.Entities
{
    public class Rial : AlloyWheel
    {
        public Rial()
        {
            Brand = "Rial";
        }
        public string? Brand { get; private set; }
        public int WheelsTableID { get; set; }
        public WheelsTable? WheelsTable { get; set; }
    }
}
