# Todo List API Documentation

## 1. Project Architecture
The project follows a **3-Tier Architecture** to ensure separation of concerns:
- **Controller:** Handles HTTP requests and returns responses.
- **Service:** Contains business logic.
- **Repository:** Manages direct data operations with SQL Server via `DbContext`.

## 2. API Endpoints
The following endpoints are implemented under the base route `/api/todos`:

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| GET | `/api/todos` | Retrieve all todo items. |
| GET | `/api/todos/{id}` | Retrieve a specific item by ID. |
| POST | `/api/todos` | Create a new todo item. |
| PUT | `/api/todos/{id}` | Update an existing item. |
| DELETE | `/api/todos/{id}` | Remove an item from the database. |

## 3. Data Model
The `TodoItem` model consists of:
- `Id` (int): Primary Key.
- `Title` (string): The description of the task.
- `IsCompleted` (bool): The status of the task.

## 4. Sample Test Result
When calling `GET http://localhost:xxxx/api/todos`, the API returns a JSON array of tasks.