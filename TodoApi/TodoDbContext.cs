using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        // Bảng Todos trong SQL Server sẽ được tạo từ đây
        public DbSet<TodoItem> Todos { get; set; } 
    }
}