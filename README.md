The project goal was to create a front end, back end, a fully functional database and github integration, this task needs to be completed on Visual Studio 2022. We start by opening VS2022 and enabling the ASP.NET core MVC web app with this templete
we can enable the use of identity and entity framework. What this framework does is create the Controllers, data and view files with their corripsonding data.

In order to get identity framework enabled go to NUget packages and recieve Microsoft,Visual,Web,CodeGeneration,Design after that go to the Applicationinstance in this case SAOnlineMarket and rightclick then go to CreateScafolditem
-Select Identity
-Select Register, Login and logout in the tickboxes
-Choose Appropriate Upperclass, DbContext and viewmodel.
-Add

Once this has been completed go to program.cs and add app.userazorpages();
Go to view/shared and _layout add partial class = "_LoginPartial"

This will enable the template registration and login page to display with full functionality.

Afterwards add new migration and update the database so that new registers will reflect on the database that identity made

-Create Models folder
-Create classes inside the folder
-Once inside the classes create appropriate {get;set;} values for the database


