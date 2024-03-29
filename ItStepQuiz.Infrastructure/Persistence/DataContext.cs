﻿using ItStepQuiz.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItStepQuiz.Infrastructure.Persistence;

public class DataContext : DbContext
{
    public DataContext() { }
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public virtual DbSet<Game> Games { get; set; } = null!;
    public virtual DbSet<Answer> Answer { get; set; } = null!;
    public virtual DbSet<Questions> Questions { get; set; } = null!;

}
