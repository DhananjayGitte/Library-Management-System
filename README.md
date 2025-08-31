📚 Library Management System

A desktop-based Library Management System built with C# (.NET Framework) and MySQL as the backend. This application helps librarians manage books, members, and transactions like issue/return efficiently.

🚀 Features

📖 Add, update, delete, and view books

👥 Manage library members

🔑 User authentication (Admin / Librarian)

🔄 Book issue and return system

📊 Track availability of books

🗄️ Database-driven using MySQL

🛠️ Technologies Used

C# / .NET (Windows Forms / WPF depending on UI)

MySQL Database

ADO.NET (for DB connectivity)

⚙️ Setup Instructions
1. Clone the Repository
git clone https://github.com/DhananjayGitte/Library-Management-System.git
cd Library-Management-System

2. Setup the Database

Install MySQL (if not already installed).

Create a new database, e.g., library_db.

Import the schema and sample data:

mysql -u root -p library_db < Database/database.sql

3. Configure Database Connection

Open the solution in Visual Studio (LibraryM/LibraryM.sln).

Find the database connection string in the code (e.g., app.config or directly in DB connection class).

Update with your MySQL username, password, and database name:

<connectionStrings>
  <add name="LibraryDb" 
       connectionString="server=localhost;user id=root;password=your_password;database=library_db;" 
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>

4. Run the Application

Build and run the project from Visual Studio (F5).

📂 Project Structure
Library-Management-System/
│── Database/              # SQL schema & sample data
│   └── database.sql
│── LibraryM/              # C# source code (Visual Studio solution)
│   ├── LibraryM.sln
│   ├── LibraryM/          # Main project files
│── README.md              # Project documentation
│── .gitignore

🔒 Notes

Do NOT commit real MySQL passwords to GitHub.

Update connection strings locally in app.config or settings.

Use sample credentials in docs, not real ones.

🤝 Contributing

Fork the repository

Create a feature branch (git checkout -b feature-name)

Commit changes (git commit -m "Added new feature")

Push branch (git push origin feature-name)

Open a Pull Request
