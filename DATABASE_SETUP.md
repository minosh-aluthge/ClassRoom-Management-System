# Database Setup Instructions

Since database files (.mdf and .ldf) are excluded from the repository for security and size reasons, follow these steps to set up the database:

## Prerequisites
- SQL Server Express or SQL Server LocalDB
- SQL Server Management Studio (SSMS) or Visual Studio

## Database Schema

### Tables Required:

#### 1. ADMIN Table
```sql
CREATE TABLE [dbo].[ADMIN] (
    [ID] NVARCHAR(50) NOT NULL PRIMARY KEY,
    [PASS] NVARCHAR(50) NOT NULL
);
```

#### 2. REGISTER Table
```sql
CREATE TABLE [dbo].[REGISTER] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [USERNAME] NVARCHAR(100) NOT NULL,
    [EMAIL] NVARCHAR(100) NOT NULL,
    [PASSWORD] NVARCHAR(100) NOT NULL,
    [CREATED_DATE] DATETIME DEFAULT GETDATE()
);
```

#### 3. CLASS Table
```sql
CREATE TABLE [dbo].[CLASS] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [CLASS_NAME] NVARCHAR(100) NOT NULL,
    [DESCRIPTION] NVARCHAR(500),
    [CAPACITY] INT,
    [CREATED_DATE] DATETIME DEFAULT GETDATE()
);
```

## Setup Steps:

1. **Create Database**
   ```sql
   CREATE DATABASE CLASSROOM_DB;
   ```

2. **Run Table Creation Scripts**
   - Execute the SQL scripts above in your database

3. **Insert Sample Admin User**
   ```sql
   INSERT INTO [dbo].[ADMIN] (ID, PASS) VALUES ('admin', 'admin123');
   ```

4. **Update Connection String**
   - Update the connection string in your source code files to match your SQL Server configuration
   - Default format: `Data Source=YOUR_SERVER;Initial catalog=CLASSROOM_DB;Integrated Security=True`

## Configuration Files to Update:
- Update connection strings in `*.cs` files that contain database connections
- Modify `App.config` if it contains database connection settings

## Notes:
- Default admin credentials: Username: `admin`, Password: `admin123`
- Change default credentials for production use
- Ensure SQL Server service is running before launching the application
