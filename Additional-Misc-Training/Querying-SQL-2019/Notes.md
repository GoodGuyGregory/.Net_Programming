## Creating a DB with SQLCMD

```powershell
#  shows all commands
sqlcmd -?

#  connnect to the server instance and crate a db
sqlcmd -S <ServerName> -U [username] -P <password>

#  if all the information is correct you will be inside of that server and able to create a db

#  execute the db creation command
CREATE DATABASE Kinetico
GO

```