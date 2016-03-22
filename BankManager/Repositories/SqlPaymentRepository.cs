﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace Repositories
{
    public class SqlPaymentRepository : Repositories.SqlBaseRepository, IPaymentRepository
    {
        #region
        private const string spGetPaymentsQuery = "spGetPayments";
        private const string spPassPaymentQuery = "spPassNewPayment";
        #endregion

        #region Constructor
        public SqlPaymentRepository(string connectionString) : base(connectionString)
        {
        }
        #endregion

        #region Public methods
        public IEnumerable<Payment> GetPayments()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(spGetPaymentsQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Payment> resultList = new List<Payment>();

                        while(reader.Read())
                        {
                            resultList.Add(new Payment
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                CreditId = Convert.ToInt32(reader["CreditId"].ToString()),
                                PaymentDate = Convert.ToDateTime(reader["PaymentDate"].ToString()),
                                Amount = Convert.ToDecimal(reader["Amount"].ToString()),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }
                        return resultList;
                    }
                }
            }
        }

        public IEnumerable<Payment> GetPayments(int creditId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(spGetPaymentsQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@creditId", creditId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Payment> resultList = new List<Payment>();

                        while(reader.Read())
                        {
                            resultList.Add(new Payment
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                CreditId = Convert.ToInt32(reader["CreditId"].ToString()),
                                PaymentDate = Convert.ToDateTime(reader["PaymentDate"].ToString()),
                                Amount = Convert.ToDecimal(reader["Amount"].ToString()),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public int PassPayment(Payment newPayment)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                using (SqlCommand command = new SqlCommand(spPassPaymentQuery, connection))
                {
                    command.Transaction = transaction;

                    SqlParameter newPaymentId = new SqlParameter("@newPaymentId", System.Data.SqlDbType.Int);
                    newPaymentId.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(newPaymentId);

                    try
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@creditId", newPayment.CreditId);
                        command.Parameters.AddWithValue("@paymentDate", newPayment.PaymentDate);
                        command.Parameters.AddWithValue("@amount", newPayment.Amount);
                        command.Parameters.AddWithValue("@userId", newPayment.UserId);

                        command.ExecuteNonQuery();
                        
                        transaction.Commit();
                        return Convert.ToInt32(newPaymentId.Value.ToString());
                    }
                    catch
                    {
                        transaction.Rollback();
                        //return Convert.ToInt32(newPaymentId.Value.ToString());
                        throw;
                    }
                }
            }
        }

        public override bool SaveTable()
        {
            IEnumerable<Payment> payments = GetPayments();
            try
            {
                using (StreamWriter writer = new StreamWriter(new FileStream("Payments.csv", FileMode.Create)))
                {
                    writer.WriteLine(@"""Id"";""CreditId"";""PaymentDate"";""Amount"";""UserId"";");
                    foreach (var payment in payments)
                    {
                        writer.WriteLine(@"""{0}"";""{1}"";""{2}"";""{3}"";""{4}"";", payment.Id, payment.CreditId, payment.PaymentDate, payment.Amount, payment.UserId);
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
