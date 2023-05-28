# AspNet-Task
To make this project work you must have SQL server installed.
Clone the project to your computer.
Make sure that the databases have been created. You can create them by opening the Package Manager Console and running Update-Database -Context ApplicationDbContext and Update-Database -Context ProductDbContext.

If it doesn´t work, adapt the connection string to your computer.

The project will automatically seed the database with a few products.

Other stuff:
In order to see the backoffice you must have created a user, then simply go to **/admin** _Only the first user will become an administrator_
