using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using CommanLayer.Models;

namespace DataAccessLayer
{
    public class EmployeeDataAccessDb
    {
        private DbConnection db = new DbConnection();
        public List<Employess> GetEmployees()
        {
            string query = "select * from mulititerTab";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.cnn;
            if(db.cnn.State==System.Data.ConnectionState.Closed)
            {
                db.cnn.Open();
            }
               SqlDataReader reader = command.ExecuteReader();
                List<Employess> employesses = new List<Employess>();
                while(reader.Read())
                {
                    Employess emp = new Employess();
                    emp.id = (int)reader["id"];
                    emp.FirstName = reader["Firstname"].ToString();
                    emp.LastName = reader["Lastname"].ToString();
                    emp.Email = reader["Email"].ToString();
                    emp.Gender = reader["Gender"].ToString();
                    employesses.Add(emp);
                }
                db.cnn.Close();
                return employesses;
           
        }

        
    }
}
