
using Microsoft.EntityFrameworkCore;
using MvcBalloon.Models;

namespace MvcBalloon.Data
{
    public class MvcBalloonContext: DbContext
    {
        public MvcBalloonContext(DbContextOptions<MvcBalloonContext> options) 
            : base(options)
        {

        }
        public DbSet<Balloon> Balloon { get; set; }
    }
}
