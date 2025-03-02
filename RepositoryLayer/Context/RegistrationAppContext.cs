using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    //Create the Context class here -> 
    //The RegistrationAppContext class is your Entity Framework Core (EF Core) database context, which acts as a bridge between your ASP.NET Core application and the database. 
    public class RegistrationAppContext : DbContext
    {
        public RegistrationAppContext(DbContextOptions<RegistrationAppContext> options) : base(options)
        {

        }

        //The DbSet<UserEntity> Users property tells EF Core to create and manage a table named Users in the database.
        //UserEntity represents the structure (columns, relationships) of the Users table.

        public virtual DbSet<Entity.UserEntity> Users { get; set; }//Here the UserEntity defines the table structure in the dataBase and the users is the name of the table 
    }
    //After this go to appsettings.json -> 

    //Add this to your json



}

//This is a connection string used in your ASP.NET Core application to connect to a SQL Server database. Let’s break it down step by step.

//A connection string is a piece of text that contains all the information needed to connect your application to a database. It tells Entity Framework Core (EF Core) or ADO.NET where your database is, what it's called, and how to authenticate.

//In your case, the connection string is stored in appsettings.json:

//Data Source = LAPTOP - TVN4GDMR\\SQLEXPRESS	Specifies the server name where SQL Server is running. Here, LAPTOP-TVN4GDMR is the computer name, and SQLEXPRESS is the SQL Server instance.

//Initial Catalog = UserRegistrationAPI	Specifies the database name (UserRegistrationAPI). This is where your tables (like Users) are stored.

//Integrated Security = TRUE	Uses Windows Authentication to connect to the database instead of a username and password.

//"ConnectionStrings": {
//    "SqlConnection": "Data Source =LAPTOP-TVN4GDMR\\SQLEXPRESS; Initial Catalog = UserRegistrationAPI; Integrated Security = TRUE;"
//}