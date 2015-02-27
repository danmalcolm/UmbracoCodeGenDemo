# Umbraco CodeGen Demo

Demonstrates the Umbraco CodeGen plugin on a simple project.

## Project and Database Setup

The repo contains a backup of a SQL Server database with the Umbraco configuration and sample data needed to run the project. Open the setup folder and run setup.bat to install the database.

The application is configured to connect to a SQL Server LocalDB instance with a server name of "(localdb)\v11.0" running on the developer's machine. This is normally available if you have installed Visual Studio (version 2012 upwards). Please read [Introducing LocalDB, an improved SQL Express](http://blogs.msdn.com/b/sqlexpress/archive/2011/07/12/introducing-localdb-a-better-sql-express.aspx) for further information about LocalDB.

If you have trouble using LocalDB or restoring via the setup.bat batch file, restore the database manually from the backup file in the setup folder and modify the connection string in the application's web.config accordingly.
