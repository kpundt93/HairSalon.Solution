# _Eau Claire's Salon_

#### By: _*Katie Pundt*_

#### _A web application to manage stylists and clients at a hair salon._

## Technologies Used
* C#
* .NET5
* ASP.NET Core MVC
* Razor
* NuGet
* git
* GitHub
* MySql

## Description
_A MVC web application for a hair salon owner to manage stylists and their clients. With complete Create, Read, and Update functionality._

![Screenshot of database schema](/schema.png)
## System Requirements
* Download and install [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* A text editor, such as [VS Code](https://code.visualstudio.com/)
* MySQL and MySQL Workbench

## Setup/Installation Instructions
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kpundt93/HairSalon.Solution.git`
* After cloning the project, navigate into it using the command `cd HairSalon.Solution/HairSalon`
* Create a file named "appsettings.json" in the `HairSalon` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=katie_pundt;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Open MySQL Workbench and log into your server
* Find the "Navigator" panel and select the "Administration" tab
* Click on "Data Import/Restore"
* Select "Import from Self-Contained File" and navigate to where you cloned the project
* Under "Default Schema to be Imported To" select "New..."
* Name the new schema "katie_pundt" and click "OK"
* Click "Start Import" in the bottom right corner
* After the import is finished, go back to the "Navigator" panel and switch to the "Schemas" tab
* Once in the "Schemas" tab, right-click and select "Refresh All" to see the imported database
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to run the project in the browser

## Known Bugs
* _No known bugs_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Katie Pundt_