namespace WheelsBlazor.Data.Entities
{
    public class Anzio : AlloyWheel
    {
        public Anzio()
        {
            Brand = "Anzio";
        }
        public string? Brand { get; private set; }
        public int WheelsTableID { get; set; }
        public WheelsTable? WheelsTable { get; set; }
    }
}
