# visualbasic-sqlite-desktop-crud
A portable Visual Basic Desktop Application. Implements full CRUD functionality using SQLite. No database setup required—just clone and run



to use sql lite: download from :
https://sqlite.org/download.html


then run on cli

sqlite3 app.db


CREATE TABLE product (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Price REAL NOT NULL
);


.tables


.schema product


System.Data.SQLite