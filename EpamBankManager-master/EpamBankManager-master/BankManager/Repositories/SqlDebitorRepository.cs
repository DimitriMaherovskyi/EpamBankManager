// Review DM: Unused are not removed.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace Repositories
{
    public class SqlDebitorRepository : SqlBaseRepository, IDebitorRepository
    {
        #region Private fields
        private const string spGetDebitorsQuery = "spGetDebitors";
        private const string spNewDebitorQuery = "spAddNewDebitor";
        #endregion

        #region Constructor
        public SqlDebitorRepository(string connectionString) : base(connectionString)
        {
        }
        #endregion

        #region Public methods
        public IEnumerable<Debitor> GetDebitors(string firstName, string lastName, string address, string phone)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Review DM: Missed space.
                using (SqlCommand command = new SqlCommand(spGetDebitorsQuery, connection))
                {
                    // Review DM: using System.Data; 
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@searchedFName", firstName);
                    command.Parameters.AddWithValue("@searchedLName", lastName);
                    command.Parameters.AddWithValue("@searchedAddress", address);
                    command.Parameters.AddWithValue("@searchedPhone", phone);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Debitor> resultList = new List<Debitor>();

                        while(reader.Read())
                        {
                            // Review DM: new Debitor()
                            resultList.Add(new Debitor
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public IEnumerable<Debitor> GetDebitors()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Review DM: Missed space.
                using (SqlCommand command = new SqlCommand(spGetDebitorsQuery, connection))
                {
                    // Review DM: using System.Data;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Debitor> resultList = new List<Debitor>();

                        while (reader.Read())
                        {
                            // Review DM: new Debitor()
                            resultList.Add(new Debitor
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Address = reader["Address"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }
                        // Review DM: Missed space. 
                        return resultList;
                    }
                }
            }
        }

        public int AddDebitor(Debitor newDebitor)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(spNewDebitorQuery, connection))
                {
                    // Review DM: using System.Data;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName", newDebitor.FirstName);
                    command.Parameters.AddWithValue("@lastName", newDebitor.LastName);
                    command.Parameters.AddWithValue("@address", newDebitor.Address);
                    command.Parameters.AddWithValue("@phoneNumber", newDebitor.PhoneNumber);
                    command.Parameters.AddWithValue("@userId", newDebitor.UserId);

                    SqlParameter newId = new SqlParameter("@newDebitorId", System.Data.SqlDbType.Int);
                    newId.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(newId);

                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@newDebitorId"].Value.ToString());
                }
            }
        }

        // I won't do this bool. I has to catch exception of messagebox.
        public override bool SaveTable()
        {
            IEnumerable<Debitor> debitors = GetDebitors();
            try
            {
                using (StreamWriter writer = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create)))
                {
                    writer.WriteLine(@"""Id"";""FirstName"";""LastName"";""Address"";""PhoneNumber"";""UserId"";");
                    foreach (var debitor in debitors)
                    {
                        // Review DM: ("${Id} {Name}");...
                        writer.WriteLine(@"""{0}"";""{1}"";""{2}"";""{3}"";""{4}"";""{5}"";", debitor.Id, debitor.FirstName, debitor.LastName, debitor.Address, debitor.PhoneNumber, debitor.UserId);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
} 
