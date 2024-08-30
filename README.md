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

Once completed we will use EntityScafolding to create the controllers, views and dataconnectionstrings for the database.
-rightclick on the controllers folder
-add new controller
-select the bottom option (with views and entity framework)
-and choose the data model and database for migrations and press add.

do this for all the models, the entity framework will create all the conntections.

Afterwards you must create seed vallues in the controller modules for the frontend so that it is not hardcodes and vallues users input will be stored in the database.

Once the values have been seeded add migration and update the database via package manager

-Create a front end that under View/Home/Indexcshtml that can store values that it receives from the user.
-The Home controller will add the functionality to that page in terms of values received from the front end inputs and store that in the database
-the next parts is just customizing the front end in coralation with you're requirements
-If a new View page is made that must store values create a controller and seed base values and add migration and update database.

Using SQL view manager you can view the database that was created all of the stored values of the frontend user inputs.
