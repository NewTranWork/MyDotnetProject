using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class TodoRepository
    {
        private readonly TodoDbContext _context;

        // Bơm TodoDbContext vào để sử dụng
        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        // 1. Lấy tất cả Todo
        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _context.Todos.ToListAsync();
        }

        // 2. Lấy 1 Todo theo Id
        public async Task<TodoItem?> GetByIdAsync(int id)
        {
            return await _context.Todos.FindAsync(id);
        }

        // 3. Thêm mới Todo
        public async Task AddAsync(TodoItem item)
        {
            _context.Todos.Add(item);
            await _context.SaveChangesAsync(); // Lưu xuống SQL Server
        }

        // 4. Cập nhật Todo
        public async Task UpdateAsync(TodoItem item)
        {
            _context.Todos.Update(item);
            await _context.SaveChangesAsync();
        }

        // 5. Xóa Todo
        public async Task DeleteAsync(int id)
        {
            var item = await _context.Todos.FindAsync(id);
            if (item != null)
            {
                _context.Todos.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}