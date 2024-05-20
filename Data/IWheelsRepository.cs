using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Data
{
    public interface IWheelsRepository
    {
        IQueryable<WheelsTable> WheelsTables { get; }
        IQueryable<Rial> Rials { get; }
        IQueryable<Alutec> Alutecs { get; }
        IQueryable<Anzio> Anzios { get; }
        IQueryable<Ats> Ats { get; }
        public void CreateWheel(WheelsTable wheel);
        public void CreateAlutec(Alutec alutec);
        public void CreateAnzio(Anzio anzio);
        public void CreateRial(Rial rial);
        public void CreateAts(Ats ats);
        public Task<FetchedData[]> GetCombinedWheelsDataAsync();
    }
}
