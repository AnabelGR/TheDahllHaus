﻿# The Dahll Haus

### An Epicodus capstone project in .NET/Visual Studio 2015, 08.31.17

#### **By Anabel Ramirez**

## Description

A website for The Dahll Haus, a headdress, costume, and wig maker as well as MUA services and repair.


## Setup/Installation Requirements

#### Requirements

If you do not have Visual Studio 2015, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

Cloning From GitHub: Download or clone project repository onto desktop from GitHub using this [link](https://github.com/AnabelGR/TheDahllHaus.git). In the command terminal, navigate to the src/TheDahllHaus folder and run the following command to restore packages:
```terminal
dotnet restore
```

Open the project in Visual Studio.

#### Migrations Setup

1. In Visual Studio, open the 'Solution Explorer' window.
2. Right-click the project root folder and choose 'Open in File Explorer' from the context menu.
3. Enter "cmd" in the address bar and press Enter.
4. Enter the following command in the command window:
```terminal
dotnet ef database update
```
5. Open artcult.sql in SSMS and execute (this will add sample data).
6. Back in Visual Studio, click 'IIS Express' at the top of the window. Project will open in a new localhost window on your default browser.

## Screenshots


## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact the contributor through Github.

## Technologies Used

**Languages:** HTML, SCSS, C#, ASP.NET

**IDE:** Visual Studio 2015

**Design Framework:** UIKit

**Database Management:** MySQL (SSMS)

### License
This software is licensed under the MIT license.

Copyright (c) 2017 **Anabel Ramirez**
