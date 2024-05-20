namespace WheelsBlazor.Data.Entities
{
    public class Alutec : AlloyWheel
    {
        public Alutec()
        {
            Brand = "Alutec";
        }
        public string? Brand { get; private set; }
        public int WheelsTableID { get; set; }
        public WheelsTable? WheelsTable { get; set; }
    }
}
