using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oobooks_Api.Models
{
    public class OobooksDbContext : DbContext
    {
        public OobooksDbContext(DbContextOptions<OobooksDbContext> options)
            : base(options)
        {
        }

        // thêm db set tại đây ví dụ
        //public DbSet<TodoItem> TodoItems { get; set; }
    }
}
