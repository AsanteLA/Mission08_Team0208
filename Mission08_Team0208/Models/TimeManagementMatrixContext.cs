using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0208.Models;

public partial class TimeManagementMatrixContext : DbContext
{

    public TimeManagementMatrixContext(DbContextOptions<TimeManagementMatrixContext> options) : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Quadrant> Quadrants { get; set; }

    public virtual DbSet<TaskInfo> Tasks { get; set; }

}
