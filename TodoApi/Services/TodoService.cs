using TodoApi.Models;
using TodoApi.Repositories;

namespace TodoApi.Services
{
    public class TodoService
    {
        private readonly TodoRepository _repository;

        // Bơm Repository vào để Service sử dụng
        public TodoService(TodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TodoItem>> GetAllTodosAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TodoItem?> GetTodoByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddTodoAsync(TodoItem item)
        {
            // Nơi này sau này bạn có thể thêm logic kiểu như: 
            // Nếu tên Todo trống thì báo lỗi không cho Add...
            await _repository.AddAsync(item);
        }

        public async Task UpdateTodoAsync(TodoItem item)
        {
            await _repository.UpdateAsync(item);
        }

        public async Task DeleteTodoAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}