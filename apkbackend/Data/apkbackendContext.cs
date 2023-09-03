using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apkbackend.Pages.Models;

namespace apkbackend.Data
{
    public class apkbackendContext : DbContext
    {
        public apkbackendContext (DbContextOptions<apkbackendContext> options)
            : base(options)
        {
        }

        public DbSet<apkbackend.Pages.Models.Project> Project { get; set; } = default!;
    }
}
