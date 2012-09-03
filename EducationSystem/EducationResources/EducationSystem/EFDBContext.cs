using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EducationResources.EducationSystem
{
    public class EFDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
