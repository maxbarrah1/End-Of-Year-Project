using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace APIEndOfYearProject.Classes
{
    public static class DatabaseHandler
    {
        static string GetConnectionString(){
            try{
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = " "; //database link
                builder.UserID = " "; //database username
                builder.Password = " ";  //database password
                builder.InitialCatalog = " "; //database to connect to
                return builder.ConnectionString;
            }
            catch(exception e){
                throw new Exception("Error in GetConnectionString() : " + e.Message); 
            }
        }
        /*
        public static List<GameBrief> GetGameBriefs(){
            List<GameBrief> gamebriefs = new List<GameBrief>();
            using(SQLConnection conn = new SqlConnection(GetConnectionString())){
                conn.Open();
                using (SQLCommand command = new SQLCommand("SELECT * FROM GAME")){
                    using(SqlDataReader reader = command.ExecuteReader()){
                        while(reader.Read()){
                            gamebriefs.Add(new GameBrief(){GameID = reader.GetString(0), Winner = reader.GetString(1)});
                        }
                    }
                }


                conn.Close();
            }
            return gamebriefs;
        }
        */

        
    }
}