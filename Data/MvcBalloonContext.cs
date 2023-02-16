using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBalloon.Models;
namespace MvcBalloon.Data
{
    public class MvcBalloonContext: DbContext
    {
        public MvcBalloonContext(DbContextOptions<MvcBalloonContext> options) : base(options)
        {

        }
        public DbSet<Balloon> balloon { get; set; }
    }
}
