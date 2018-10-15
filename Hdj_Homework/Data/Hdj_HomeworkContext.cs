using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hdj_Homework.Models
{
    public class Hdj_HomeworkContext : DbContext
    {
        public Hdj_HomeworkContext (DbContextOptions<Hdj_HomeworkContext> options)
            : base(options)
        {
        }

        public DbSet<Hdj_Homework.Models.Member> Member { get; set; }
    }
}
