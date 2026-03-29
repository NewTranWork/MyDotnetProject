using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    // Cấu hình đường dẫn mặc định cho toàn bộ các hàm bên dưới là /api/todos
    [Route("api/[controller]")] 
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly TodoService _service;

        // Bơm Service vào Controller
        public TodosController(TodoService service)
        {
            _service = service;
        }

        // 1. GET: /api/todos (Lấy danh sách tất cả công việc)
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todos = await _service.GetAllTodosAsync();
            return Ok(todos); // Trả về mã 200 OK kèm dữ liệu
        }

        // 2. GET: /api/todos/5 (Lấy 1 công việc theo Id)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var todo = await _service.GetTodoByIdAsync(id);
            if (todo == null) return NotFound(); // Trả về lỗi 404 nếu không tìm thấy
            return Ok(todo);
        }

        // 3. POST: /api/todos (Thêm mới 1 công việc)
        [HttpPost]
        public async Task<IActionResult> Create(TodoItem item)
        {
            await _service.AddTodoAsync(item);
            // Trả về mã 201 Created và link để xem lại item vừa tạo
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        // 4. PUT: /api/todos/5 (Cập nhật 1 công việc)
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TodoItem item)
        {
            if (id != item.Id) return BadRequest(); // Báo lỗi 400 nếu Id trên link và trong data không khớp
            
            await _service.UpdateTodoAsync(item);
            return NoContent(); // Trả về mã 204 Thành công nhưng không có data gì cần hiển thị thêm
        }

        // 5. DELETE: /api/todos/5 (Xóa 1 công việc)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteTodoAsync(id);
            return NoContent();
        }
    }
}