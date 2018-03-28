using System;
using Microsoft.EntityFrameworkCore;

namespace MultipleContext.Workflow
{
    public class WorkflowContext : DbContext
    {
        public WorkflowContext(DbContextOptions<WorkflowContext> options) : base(options) { }

        public DbSet<Flow> Flows { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Workflow");
            modelBuilder.Entity<Flow>().ToTable("Flow");
            modelBuilder.Entity<Document>().ToTable("Document");
        }
    }
}
