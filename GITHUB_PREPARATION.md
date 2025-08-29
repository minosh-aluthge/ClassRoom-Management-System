# Configuration Guide for GitHub Repository

## Before Committing to GitHub

This guide helps you prepare the codebase for public repository while protecting sensitive information.

## 🔧 Required Changes

### 1. Database Connection Strings

**Files to Update:**
- `vidumina/ADMIN.cs` (line ~22)
- `vidumina/LOGIN.cs` (line ~31) 
- `vidumina/ADDCLASS.cs` (line ~59)

**Current Connection String:**
```csharp
SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True");
```

**Recommended Generic Connection String:**
```csharp
SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial catalog=CLASSROOM_DB;Integrated Security=True");
```

### 2. UI Text References

**Files to Update:**
- `vidumina/ADDCLASS.Designer.cs` (line ~187)
- `vidumina/ADMIN.Designer.cs` (line ~129)
- `vidumina/CONTACT_US.Designer.cs` (lines ~73, ~136, ~181)

**Current Text References:**
```csharp
this.label1.Text = "VIDUMINA HORANA";
this.label7.Text = "vidumina@hotmail.com";
this.label3.Text = "Vidumina , horana";
```

**Recommended Generic Text:**
```csharp
this.label1.Text = "CLASSROOM MANAGEMENT";
this.label7.Text = "info@classroom-app.com";
this.label3.Text = "Educational Institution";
```

## 🛡️ Security Recommendations

### 1. Use Configuration Files
Consider moving connection strings to `App.config`:

```xml
<configuration>
  <connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial catalog=CLASSROOM_DB;Integrated Security=True" />
  </connectionStrings>
</configuration>
```

### 2. Environment Variables
For production, use environment variables:
```csharp
string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") 
    ?? @"Data Source=(LocalDB)\MSSQLLocalDB;Initial catalog=CLASSROOM_DB;Integrated Security=True";
```

## 📝 Quick Replace Commands

If using Visual Studio:
1. **Find and Replace** (Ctrl+H)
2. **Find:** `VIDUMINA HORANA` → **Replace:** `CLASSROOM MANAGEMENT`
3. **Find:** `VIDUMINA` → **Replace:** `CLASSROOM_DB` (in connection strings only)
4. **Find:** `DESKTOP-GPV2538\SQLEXPRESS` → **Replace:** `(LocalDB)\MSSQLLocalDB`

## ✅ Final Checklist

Before committing:
- [ ] Updated all connection strings to generic format
- [ ] Replaced specific institution names with generic text
- [ ] Updated email addresses to generic ones
- [ ] Verified no personal/sensitive information in code
- [ ] Tested application with new connection string
- [ ] Updated README.md with setup instructions
- [ ] Created DATABASE_SETUP.md with schema

## 🚀 Git Commands for Initial Commit

```bash
# Initialize repository
git init

# Add all files (respecting .gitignore)
git add .

# Create initial commit
git commit -m "Initial commit: ClassRoom Management System - Diploma Project 2023"

# Add remote repository
git remote add origin https://github.com/yourusername/ClassRoom-Management-System.git

# Push to GitHub
git push -u origin main
```

## 📋 Repository Settings

**Recommended Repository Settings:**
- **Name:** `ClassRoom-Management-System`
- **Description:** `🎓 A comprehensive classroom management desktop application built with C# Windows Forms. Features student registration, class administration, user authentication, and database integration. Diploma project showcasing Windows desktop application development skills (2023).`
- **Topics:** `csharp`, `windows-forms`, `classroom-management`, `desktop-app`, `school-system`, `diploma-project`, `sql-server`, `education`
- **License:** MIT License
- **Include README:** ✅
- **Public Repository:** ✅
