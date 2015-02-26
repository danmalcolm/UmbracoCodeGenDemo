Ensure localdb is running

sqllocaldb start v11.0

set sqlcmd="C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE"
sqlcmd -E -S (localdb)\v11.0 -Q "CREATE DATABASE UmbracoCodeGenDemo"
