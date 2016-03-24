// Review DM: Unused not deleted.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.IO;

namespace Repositories
{
    public class SqlTypeOfCreditRepository : SqlBaseRepository, ITypeOfCreditRepository
    {
        #region Private fields
        private const string spGetTypesOfCreditQuery = "spGetTypesOfCredit";
        #endregion

        #region Constructor
        public SqlTypeOfCreditRepository(string connectionString) : base(connectionString)
        {

        }
        #endregion

        #region Public Methods
        public IEnumerable<TypeOfCredit> GetTypes()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // Review DM: Missed space.
                using (SqlCommand command = new SqlCommand(spGetTypesOfCreditQuery, connection))
                {
                    // Review DM: using System.Data;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();
                    List<TypeOfCredit> resultList = new List<TypeOfCredit>();
                    // Review DM: Missed space.
                    while (reader.Read())
                    {
                        // new TypeOfCredit()
                        resultList.Add(new TypeOfCredit
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            Type = reader["Type"].ToString(),
                            MaxTerm = Convert.ToInt32(reader["MaxTerm"].ToString())
                        });
                    }
                    // Review DM: Missed space.
                    return resultList;
                }
            }
        }

        // I won't do this bool. It must catch exception or messagebox.
        public override bool SaveTable()
        {
            IEnumerable<TypeOfCredit> types = GetTypes();

            try
            {
                using (StreamWriter writer = new StreamWriter(new FileStream("TypesOfCredits.csv", FileMode.Create)))
                {
                    writer.WriteLine(@"""Id"";""Type"";""MaxTerm"";");
                    foreach (var elem in types)
                    {
                        // Review DM: ($"{Id} {Name}");...
                        writer.WriteLine(@"""{0}"";""{1}"";""{2}"";", elem.Id, elem.Type, elem.MaxTerm);
                    }
                }
                // Review DM: Missed space.
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
