using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace APIEndOfYearProject.Classes
{
    public class DatabaseHandler
    {
        static string GetConnectionString(){
            try{
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = " "; //database link
                builder.UserID = " "; //database username
                builder.Password = " ";  //database password
                builder.InitialCatalog = " "; //database name to connect to
                return builder.ConnectionString;
            }
            catch(Exception e){
                throw new Exception("Error in GetConnectionString() : " + e.Message); 
            }
        }
        

        
    }
}