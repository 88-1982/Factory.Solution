# DeAunte Hall
## Dr. Sillystringz's Factory


# Description 
  
  You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

## Setup/Installation instructions:
### From the web

  1.Go to my GitHub respository https://github.com/88-1982/Factory.Solution
  
  2. Click the green code button and click the "Download Zip" option
  
  3. Unzip the file, navigate to the "Models" directory to check the code in "Factory.csproj" to made sure frameware  needed has been downloaded.

  ### From the terminal 

  1. Clone my repository from using git clone https://github.com/88-1982/Factory.Solution in your terminal or GitBash
  
  2. Navigate to the downloaded folder using cd command
  
  3. Execute "code ." in your terminal and it will open VSCODE
  
  4. !NOTE! To run this project locally you will need to have .NET Core. You can check if you have .NET core by running dotnet -- version in the commmand line. If you do not have .NET Core you can find information to download here https://dotnet.microsoft.com/download/dotnet

  
  
  1.Create a file named "appsettings.json" in the top level of the production directory 'https://github.com/88-1982/Factory.Solution. Uploading to your own repository: If using vscode and "appsettings.json" is is not grayed out like in the image below, you may need to commit the .gitignore file included in this project first.
   
  2.Navigate to your appsettings.json and paste the following template code:

  { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=root;pwd=[password];" } }

  If you are using a server other than the default server, you will need to change the Port number. Otherwise, we will update the code to put in our database information and password. Replace "[database_name]" with the "DeAunte_Hall" and "[password]" with your password. Again this is private and should be included in a .gitignore. The final result should look like the following:

  { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=DeAunte_Hall;uid=root;pwd=mydbpassword;" } }

  3.Run Application
  From the top level directory enter 'cd Factory' in the command line.
    Run the command 'dotnet restore' to download dependencies required to run the project.
  4. Next, enter 'dotnet run' the in command line. You should a message similar to the following populate in your terminal:
  Hosting environment: Production Content root path:  http://localhost:5000 Now listening on: https://localhost:5001 Application started. Press Ctrl+C to shut down.

  Lastly, follow the link "http://localhost:5000" either via holding the 'ctrl' and clicking the link (PC), or by holding 'cmd' and clicking the link (Mac).

## Technologies Used

  C# 9
  .NET Core v5.0
  ASP.NET Core MVC
  Entity
  MySQL Workbench 8.0 CE
  REPL
  Git and GitHub

## Known bugs:
  No Known bugs at the time

## 
MIT


## Contact Information

  https://www.88-1982@github.com
  godsofolympus88@gmail.com


   