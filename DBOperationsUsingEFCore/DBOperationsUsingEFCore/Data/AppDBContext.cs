using Microsoft.EntityFrameworkCore;

namespace DBOperationsUsingEFCore.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        { 
        }
    }
}
