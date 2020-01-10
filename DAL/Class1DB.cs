using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Class1DB : IClass1DB
    {
        private IConfiguration configuration;

        public Class1DB(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public List<Class1> GetAllClass1()
        {
            List<Class1> results = null;
            string connectionString = configuration.GetConnectionString("default");

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Select * from Class1";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (results == null)
                                results = new List<Class1>();

                            Class1 class1 = new Class1();

                            class1.Id = (int)dr["Id"];

                            if (dr["name"] != null)
                                class1.Name = (string)dr["Name"];


                            results.Add(class1);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return results;
        }

    }
}
