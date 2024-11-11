using Map.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Map.DAL.DbServices
{
    public class DataService 
    {
        protected DbContext _dbContext = new MapDbContext();
        public async Task<List<UserLocation>> GetAllUserLocations()
        {
            return await _dbContext.Set<UserLocation>().ToListAsync();
        }
    }
}
