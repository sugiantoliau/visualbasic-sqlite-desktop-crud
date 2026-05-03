# visualbasic-sqlite-desktop-crud

A portable Visual Basic Desktop Application that implements full CRUD (Create, Read, Update, Delete) functionality using SQLite. This project is designed to be lightweight and portable—no heavy database server setup is required.

---

## 🚀 Quick Start

### 1. Prerequisites (SQLite CLI)
To manage the database outside of the application, download the SQLite tools:
*   Go to: [https://sqlite.org/download.html](https://sqlite.org/download.html)
*   Download the **Precompiled Binaries for Windows** (sqlite-tools-win-x64-xxxxxxx.zip).
*   Extract the files to a folder on your computer.

### 2. Database Initialization
Open your Command Line Interface (CLI) in the project's `Database` folder and run the following commands:
```sql
-- Create and open the database file
sqlite3 app.db

-- Create the product table
CREATE TABLE product (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Price REAL NOT NULL
);

-- Verify the table was created
.tables

-- View the table structure
.schema product