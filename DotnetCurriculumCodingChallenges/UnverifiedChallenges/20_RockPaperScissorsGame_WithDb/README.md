Packages to install to use EF Core:
- Install-Package Microsoft.EntityFrameworkCore.SqlServer
- Install-Package Microsoft.EntityFrameworkCore.Tools
- - Make sure the DB is not already created
- add-migration NameOfMigration => ex.CreateRockPaperScissorsDb
- dotnet ef migrations add NameOfMigrationUpdate => ex.CreateRockPaperScissorsDb
- - Update EF Tools with => Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.7
- - Update EF Tools GLOBALLY with => dotnet tool update --global dotnet-ef

To update the Db Schema after making changes
- Add-Migration addedSomeColumn
- Update-Database


How to download and connect to a database with SSMS.
The .exe for this menu window is found in the folder into which you downloaded the SSMS, SQLServer2017Media? > Developer_ENU > SETUP.EXE
1. Go to Microsoft.com to download SQL Server 2017 for Windows. (a later version may be avail)
    - Download SSMS Standalone
    Follow instructions and defualts with these exceptions
        - Install Free Developer Edition
        - In Feature Selection select 'Database Engine Services'
        - In Instance configuration give a Named Instance and InstanceID that are the SAME!
        - In Dtabase Engine Configuration select 'Mixed Mode', a password (confirm), and click 'Add Current User'.
        - YOU WILL NEED THE PASSWROD LATER (in step 5)!!!
        - Wait til your name comes up.
2. Back in the Menu click 'Install SQL Server Management Tools'
    - it takes you to the website.
    - Click Download SQL Server Management Studio 17.6.
    - If you already have SSMS installed, you can click repair to update it.
3. You may need to restart
4. Open SQL Server Management Studio from search in the bottom left.
5. When logging in..
    - Sercer Type: Database Engine
    - Server Name: It the one you just created isn't automatically there, Browse to find the new one.
    - Authentication: SQL Server Authentication
    - Login: sa (means Server Suthentication)
    - Password: the one from above step 1.
    - select remember password.
6. Open Visual Studio
    - Open View > Server Explorer
    - Under Data Connections. R-Click > New Connection.
    - Select 'Microsoft SQL Server' > Continue
    - In Add Connection window - Under Server Name, paster the name of your server just created
        - go to SSMS
        - r-click the new server
        - copy the name from the name row.
    - Authentication: SQL Server Authentication
    - User name: sa
    - Password: the same password from above.
    - unser 'Select or enter a database name', give it a name.
    - Click to create the new DB
7. Now you should have the new Db in the Server Explorer window.


