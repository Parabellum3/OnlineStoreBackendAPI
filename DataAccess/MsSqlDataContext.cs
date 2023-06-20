using Microsoft.EntityFrameworkCore;
using OnlineStoreBackendAPI.DataAccess.Abstracts;

namespace OnlineStoreBackendAPI.DataAccess
{
    public class MsSqlDataContext : BaseDbContext<MsSqlDataContext>, IDataContext
    {
        public MsSqlDataContext(DbContextOptions<MsSqlDataContext> options) : base(options) { }
    }
}
