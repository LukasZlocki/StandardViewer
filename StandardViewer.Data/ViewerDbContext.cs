using Microsoft.EntityFrameworkCore;

namespace StandardViewer.Data.Models
{
    public class ViewerDbContext : DbContext
    {
         public ViewerDbContext(DbContextOptions<ViewerDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Document> Documents {get; set;}
    }
}