using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;



namespace AttendanceClock.service
{
    internal class SQLservice
    {
        

        
        private bool _allowed;
        public string res;
        public DateTime lastEntry;
        public DateTime lastExit;




        public SQLservice(string query, string what)
        {
            

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    switch (what)
                    {
                        case "get_last_dates":
                            SqlDataReader response = cmd.ExecuteReader();
                            while (response.Read())
                            {
                                res = response["EmployeeNat"].ToString();
                                lastEntry = Convert.ToDateTime(response["LastEntry"]);
                                lastExit = Convert.ToDateTime(response["LastExit"]);
                            }
                            break;
                        
                        case "change_password":
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                res = "הסיסמה שונתה בהצלחה!";
                            }
                            else
                            {
                                res = "שינוי הסיסמה נכשל";
                            }
                            break;

                        case "insert_date":
                            int rowsAffected2 = cmd.ExecuteNonQuery();
                            if (rowsAffected2 > 0)
                            {
                                res = "הצליח";
                            }
                            else
                            {
                                res = "נכשל";
                            }
                            break;
                        default:
                            res = "השאילתה שגויה!";
                            break;
                    }
                    
                }
                catch {
                    res = "החיבור למסד הנתונים נכשל";
                }
            }
        }

        private static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("secret.json", optional: true) // Add secrets.json
             .Build();
            // Read a value from the configuration
            return builder["ConnectionString"];
        }
    }
}
 
