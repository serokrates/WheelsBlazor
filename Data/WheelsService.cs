using Microsoft.EntityFrameworkCore;
using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Data
{
    public class WheelsService
    {
        private readonly WheelsContext _context;
        public WheelsService(WheelsContext context)
        {
            _context = context;
        }

        public async Task<WheelsTable[]> GetWheelsDataAsync()
        {
                return await _context.WheelsTable.ToArrayAsync();
        }
        public async Task<string> DeleteItemService(int Id)
        {
            WheelsTable item = await _context.WheelsTable.FirstOrDefaultAsync(i => i.ID == Id);

            if (item != null)
            {
                _context.WheelsTable.Remove(item);
                await _context.SaveChangesAsync();
                return $"Item with ID {Id} deleted.";
            }
            else
            {
                return $"Item with ID {Id} not found.";
            }
        }
    }
}