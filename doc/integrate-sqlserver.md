# SQL Server Integration Report

## 1. Overview
This document describes the process of integrating SQL Server with the `TodoApi` project using Entity Framework Core (EF Core).

## 2. Environment Setup
- **Database Engine:** SQL Server 2022 (Developer Edition)
- **Management Tool:** SQL Server Management Studio (SSMS) v19+
- **ORM:** Entity Framework Core

## 3. Configuration

### Connection String
The connection was configured in `appsettings.json`. Due to local development security settings, `TrustServerCertificate=True` was added to bypass SSL certificate validation.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=TodoDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

## 4. Database Schema Migration
We used the Code-First approach. The following commands were executed to generate the database schema:

Create Migration:
dotnet ef migrations add InitialCreate

Update Database:
dotnet ef database update

## 5. Verification
After running the migration, the TodoDb database and Todos table were successfully created in SQL Server.