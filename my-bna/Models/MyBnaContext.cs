using Microsoft.EntityFrameworkCore;

namespace my_bna.Models
{
    public class MyBnaContext :DbContext
    {
        public MyBnaContext(DbContextOptions<MyBnaContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<my_bna.Models.User> User { get; set; }
    }
}