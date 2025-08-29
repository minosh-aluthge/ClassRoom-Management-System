# Database Setup Instructions for VIDUMINA

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

#### 2. REG Table (User Registration)
```sql
CREATE TABLE [dbo].[REG] (
    [NAME] NVARCHAR(50) NOT NULL PRIMARY KEY,
    [PASSWORD] NVARCHAR(50) NULL,
    [DOB] NVARCHAR(50) NULL,
    [GENDER] NVARCHAR(50) NULL,
    [ADDRESS] NVARCHAR(50) NULL,
    [CONTACTNO] NVARCHAR(50) NULL,
    [SCHOOL] NVARCHAR(50) NULL,
    [MEDIUM] NVARCHAR(50) NULL
);
```

#### 3. CLASS Table
```sql
CREATE TABLE [dbo].[CLASS] (
    [NAME] NVARCHAR(50) NOT NULL,
    [CLASS] NVARCHAR(50) NULL,
    [FEES] NVARCHAR(50) NULL,
    [PAYMENT] NVARCHAR(50) NULL,
    [PASSWORD] NVARCHAR(50) NULL,
    FOREIGN KEY ([NAME]) REFERENCES [dbo].[REG]([NAME])
);
```

## Setup Steps:

1. **Create Database**
   ```sql
   CREATE DATABASE VIDUMINA;
   ```

2. **Run Table Creation Scripts**
   - Execute the SQL scripts above in your database in the following order:
     1. First create the ADMIN table
     2. Then create the REG table 
     3. Finally create the CLASS table (due to foreign key dependency)

3. **Insert Sample Admin User**
   ```sql
   INSERT INTO [dbo].[ADMIN] (ID, PASS) VALUES ('admin', 'admin123');
   ```

4. **Update Connection String**
   - The current connection string is configured in `App.config`:
   ```xml
   <add name="vidumina.Properties.Settings.VIDUMINAConnectionString"
        connectionString="Data Source=.\sqlexpress;Initial Catalog=VIDUMINA;Integrated Security=True"
        providerName="System.Data.SqlClient" />
   ```
   - Update this connection string to match your SQL Server configuration if needed

## Configuration Files to Update:
- Update connection strings in `App.config` file
- The project uses DataSet classes (`VIDUMINADataSet.xsd`) for database operations

## Important Notes:
- The REG table uses NAME as the primary key (not an auto-increment ID)
- The CLASS table has a foreign key relationship with REG table through the NAME field
- All string fields are limited to 50 characters based on the XSD schema
- Default admin credentials: Username: `admin`, Password: `admin123`
- Change default credentials for production use
- Ensure SQL Server Express service is running before launching the application

## Database Relationships:
- REG (Parent) → CLASS (Child) through NAME field
- This allows tracking which classes each registered user is enrolled in
