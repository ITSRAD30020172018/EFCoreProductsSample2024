NOTES:
Implementing a 3 tier model

The Data layer and the Data Access layer are in the Product Model Class library project.

The Data layer is implemented in EF core 7

The Data Service Layer communicates with the DAL to expose data via the Web API controllers

To create the database, in VS2022. Make the Product Model the Startup Project. Bring up the PMC window. Issue the **Update-Database** EF command will find the Data context, 
creating the database, apply the migrations and seed the data using Has Data commands.

Once the database is created, in VS2022 make the Product Web API the Startup Project and run the Web App. This will present the Swagger interface which is turned on. You can test the Product and Weather Forecast Controller action calls. 
