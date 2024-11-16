using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TodoAPISQL.Models;

public class TodoContext : DbContext
{
    //public TodoContext()
    //    : base()
    //{
    //}
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    // //   warning To protect potentially sensitive information in your connection string,
    // //           you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
    // //for guidance on storing connection strings.

    //    optionsBuilder.UseMySQL("server=localhost;database=test;user=root;password=");
    //}
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}