using Microsoft.EntityFrameworkCore;
using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Data;
public class WheelsRepository: IWheelsRepository
{
    private readonly WheelsContext _context;
    public WheelsRepository(WheelsContext context) 
    {
        _context = context;
    }
    public IQueryable<WheelsTable> WheelsTables => _context.WheelsTable;
    public IQueryable<Rial> Rials { get; set; }
    public IQueryable<Alutec> Alutecs { get; set; }
    public IQueryable<Anzio> Anzios { get; set; }
    public IQueryable<Ats> Ats { get; set; }
    public IQueryable<FetchedData> FetchedDatas { get; set; }
    public void CreateWheel(WheelsTable wheel) 
    {
        _context.Add(wheel);
        SaveChanges();
    }
    public void CreateAlutec(Alutec alutec) 
    {
        _context.Add(alutec);
        SaveChanges();
    }
    public void CreateAnzio(Anzio anzio)
    {
        _context.Add(anzio);
        SaveChanges();
    }
    public void CreateRial(Rial rial)
    {
        _context.Add(rial);
        SaveChanges();
    }
    public void CreateAts(Ats ats)
    {
        _context.Add(ats);
        SaveChanges();
    }

    public async Task<FetchedData[]> GetCombinedWheelsDataAsync()
    {
        var data = await _context.Alutec
            .Select(a => new FetchedData
            {
                ID = a.WheelsTableID,
                BoltCircle = a.BoltCircle,
                Brand = a.Brand,
                Diameter = a.Diameter,
                Offset = a.Offset
            })
            .Union(_context.Anzio
                .Select(a => new FetchedData
                {
                    ID = a.WheelsTableID,
                    BoltCircle = a.BoltCircle,
                    Brand = a.Brand,
                    Diameter = a.Diameter,
                    Offset = a.Offset
                }).Union(_context.Ats
                .Select(a => new FetchedData
                {
                    ID = a.WheelsTableID,
                    BoltCircle = a.BoltCircle,
                    Brand = a.Brand,
                    Diameter = a.Diameter,
                    Offset = a.Offset
                }).Union(_context.Rial
                .Select(a => new FetchedData
                {
                    ID = a.WheelsTableID,
                    BoltCircle = a.BoltCircle,
                    Brand = a.Brand,
                    Diameter = a.Diameter,
                    Offset = a.Offset
                }))
                ))
            .ToArrayAsync();
        return data;

    }
    private void SaveChanges()
    {
        _context.SaveChanges();
    }
}
