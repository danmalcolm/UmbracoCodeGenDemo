@ECHO OFF

REM Settings
set sqlcmd=C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE
if not exist "%sqlcmd%" goto :SqlcmdNotFound
set dbserver=(localdb)\v11.0
set setup_dir=%~dp0
set dbname=UmbracoCodeGenDemo

sqllocaldb start v11.0 REM Ensure localdb is running - comment out if using a different server

ECHO.
ECHO What do you want to do?
ECHO.
ECHO 1. Set up database used for local development
ECHO.
ECHO 2. Remove database
ECHO.

CHOICE /C 12C /N /M "Press 1 or 2 (or C to cancel)"

IF ERRORLEVEL 3 GOTO :End
IF ERRORLEVEL 2 GOTO :Reset
IF ERRORLEVEL 1 GOTO :Install

:Install
REM Copy of original database file - in-use .mdf / .ldf files ignored by version control
copy "%setup_dir%%dbname%.mdf.original" "%setup_dir%%dbname%.mdf"
set mdffile=%setup_dir%%dbname%.mdf

"%sqlcmd%" -E -S %dbserver% -Q "EXEC sp_attach_single_file_db @dbname='%dbname%', @physname=N'%mdffile%'"
goto :End


:Reset
"%sqlcmd%" -E -S %dbserver% -Q "if exists(select 1 from sys.databases where name = '%dbname%') drop database [%dbname%]"
goto :End


:SqlcmdNotFound
echo.
echo sqlcmd.exe does not exist at the expected location: %sqlcmd%
echo You'll need to find the correct location and edit this file.
echo Now running "where sqlcmd". See below for available installations:
where sqlcmd

:End

pause
