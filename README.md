# ClassRoom Management System

## 📋 Project Overview

This is a Windows Forms desktop application developed as a diploma project in 2023. The application serves as a comprehensive classroom management system that allows users to manage classes, handle user registration and authentication, and provides administrative controls for educational institutions.

## 🎯 Features

- **User Authentication System**
  - User login and registration
  - Admin login with special privileges
  - Secure password handling

- **Class Management**
  - Add new classes
  - View existing classes
  - Admin controls for class administration

- **User Interface**
  - Intuitive Windows Forms GUI
  - Multiple forms for different functionalities
  - User-friendly navigation between forms

- **Database Integration**
  - SQL Server database connectivity
  - Data persistence for users and classes
  - Secure data handling

## 🛠️ Technologies Used

- **Framework**: .NET Framework 4.8
- **Language**: C#
- **UI**: Windows Forms
- **Database**: SQL Server (LocalDB/SQL Server Express)
- **IDE**: Visual Studio
- **Database Connectivity**: ADO.NET with SqlClient

## 📁 Project Structure

```
ClassRoom-Management-System/
├── vidumina/                    # Main application folder
│   ├── Forms/
│   │   ├── HOME.cs             # Home page form
│   │   ├── LOGIN.cs            # User login form
│   │   ├── REGISTER.cs         # User registration form
│   │   ├── ADMIN.cs            # Admin panel form
│   │   ├── ADDCLASS.cs         # Add class form
│   │   └── CONTACT_US.cs       # Contact us form
│   ├── Program.cs              # Application entry point
│   ├── VIDUMINADataSet.*       # Dataset files
│   └── App.config              # Application configuration
├── Database Files/
│   ├── vIDUMINA.mdf           # Primary database file
│   └── vIDUMINA_log.ldf       # Database log file
├── doc/                        # Documentation and screenshots
└── resoerce/                   # Application resources and images
```

## 🚀 Getting Started

### Prerequisites

- Windows OS
- .NET Framework 4.8 or higher
- SQL Server Express/LocalDB
- Visual Studio 2019 or later (for development)

### Installation

1. **Clone the Repository**
   ```bash
   git clone [repository-url]
   cd ClassRoom-Management-System
   ```

2. **Database Setup**
   - Attach the database files (`vIDUMINA.mdf` and `vIDUMINA_log.ldf`) to your SQL Server instance
   - Update the connection string in the application if necessary

3. **Build and Run**
   - Open `vidumina.sln` in Visual Studio
   - Build the solution (Ctrl + Shift + B)
   - Run the application (F5)

### Database Configuration

The application uses SQL Server with the following connection string format:
```
Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True
```

Update the connection string in the source code files to match your SQL Server configuration.

## 📊 Database Schema

The application includes the following main tables:
- **ADMIN**: Stores administrator credentials
- **REGISTER**: Stores user registration information
- **CLASS**: Stores class information

## 🖼️ Screenshots

The `doc/` folder contains various screenshots showing:
- Application home page
- Login and registration forms
- Admin panel
- Class management interface
- Database tables

## 🎓 Academic Context

This project was developed as part of a diploma program in 2023, demonstrating:
- Object-oriented programming principles
- Database design and integration
- User interface development
- Software architecture design
- Desktop application development

## 🔧 Development

### Key Components

1. **Forms**: Each form handles specific functionality (Home, Login, Register, Admin, Add Class, Contact)
2. **Database Layer**: ADO.NET implementation for data access
3. **Business Logic**: Integrated within form code-behind files
4. **Resources**: Images and UI assets stored in the `resoerce` folder

### Building from Source

1. Open the solution file `vidumina.sln` in Visual Studio
2. Restore NuGet packages if prompted
3. Ensure the database connection is properly configured
4. Build the solution
5. Run the application

## 📝 Usage

1. **Start Application**: Launch the application to see the home page
2. **Register**: New users can register through the registration form
3. **Login**: Existing users can log in with their credentials
4. **Admin Access**: Administrators can access special features through admin login
5. **Class Management**: Add and manage classes through the class management interface

## 🤝 Contributing

This is an academic project completed in 2023. While it's not actively maintained, you're welcome to:
- Fork the repository for learning purposes
- Use it as a reference for similar projects
- Suggest improvements or report issues

## 📄 License

This project was created for educational purposes as part of a diploma program.

## 👨‍💻 Author

Created as a diploma project in 2023.

## 📞 Contact

For any questions about this project, please use the contact form within the application or refer to the documentation in the `doc/` folder.

---

*This README was created to document the ClassRoom Management System developed as a diploma project in 2023.*
