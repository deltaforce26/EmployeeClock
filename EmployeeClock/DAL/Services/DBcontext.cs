using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.DAL.Services
{
    public class DBcontext
    {
        public static DataTable MakeQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable output = new DataTable();
            using (SqlConnection connection = new SqlConnection(GetConnString()))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An Error occurred: " + ex.Message);
                    }
                }
            }
            return output;
        }

        public static bool PasswordValidation(string tz, string password)
        {
            
            
            SqlParameter[] login_params = {
            new SqlParameter("@tz", tz),
            new SqlParameter("@password", password)
            };
            string loginquery = "SELECT e.EmployeeNat, p.EmployeePassword  " +
                "FROM Employees e, Passwords p WHERE e.ID = p.EmployeeID AND e.EmployeeNat = @tz and p.EmployeePassword = @password AND p.IsActive = 1;";
            DataTable data = MakeQuery(loginquery, login_params);
            if (data.Rows.Count > 0)
            {
                return true;

            }
            return false;
            
        }

        private static string GetConnString()
        {
            var config = new ConfigurationBuilder()
             .AddUserSecrets<Program>()
             .Build();
            string? cs = config["connectionString"];
            if (cs == null) throw new Exception("Cannot read conn striong from secrets");
            return cs;
        }

        public static bool CheckPassExpiaryDate(string tz, string password)
        {
            
            string cs = GetConnString();
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlParameter[] valid_params = 
                    {
                      new SqlParameter("@employeenat", tz),
                        new SqlParameter("@password", password)
                    };
                string expire_query = "SELECT expirydate FROM Passwords p INNER JOIN Employees e ON e.ID = p.EmployeeID WHERE  e.EmployeeNat = @employeenat AND  p.EmployeePassword = @password AND isactive = 1;";
                SqlCommand cmd = new SqlCommand(expire_query, connection);
                cmd.Parameters.AddRange(valid_params);
                DateTime date = Convert.ToDateTime(cmd.ExecuteScalar());
                if (DateTime.Now > date)
                {
                    MessageBox.Show("Your password ha expired please change your password");
                    FormHandler.ShowForm("ChangePasswordForm");
                    return false;
                }
                return true;
            }
                
            
            
        }
    }
}

