using Microsoft.EntityFrameworkCore;
using df-samples.Models;

namespace df_samples.Data

public class SampleContext
{ 
    public SampleContext(DbContextOptions<SampleContext> options)
        : base(options)
    {
    }

    public DbSet<Samples> Samples => Set<Samples>();
    public DbSet<Items> Items => Set<Items>();
    public DbSet<Factories> Factories => Set<Factories>();
}