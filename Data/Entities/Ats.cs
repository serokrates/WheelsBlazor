namespace WheelsBlazor.Data.Entities
{
    public class Ats : AlloyWheel
    {
        public Ats()
        {
            Brand = "Ats";
        }
        public string? Brand { get; private set; }
        public int WheelsTableID { get; set; }
        public WheelsTable? WheelsTable { get; set; }
    }
}
