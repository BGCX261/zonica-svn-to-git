USE Zonica;
EXEC sp_addlogin 'zonica', 'zonica', 'Zonica' -- Esto puede que no haga falta, por el script general de base de datos
EXEC sp_adduser 'zonica', 'zonica';
EXEC sp_addrolemember 'db_datareader', 'zonica';
EXEC sp_addrolemember 'db_datawriter', 'zonica';