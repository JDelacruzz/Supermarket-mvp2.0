using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Supermarket_mvp.Models;

namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para agregar un nuevo cliente
        public void Add(CustomersModel customer)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customer 
                                        (Document_Number, First_Name, Last_Name, Address, Birth_Day, Phone_Number, Email)
                                        VALUES (@documentNumber, @firstName, @lastName, @address, @birthDay, @phoneNumber, @email)";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customer.Document_Number;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customer.First_Name;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customer.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.AddWithValue("@birthDay", SqlDbType.NVarChar).Value = customer.Birth_Day;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customer.Email;
                command.ExecuteNonQuery();
            }
        }

        // Método para eliminar un cliente por su ID
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customer WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        // Método para editar un cliente existente
        public void Edit(CustomersModel customer)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customer
                                        SET Document_Number = @documentNumber,
                                            First_Name = @firstName,
                                            Last_Name = @lastName,
                                            Address = @address,
                                            Birth_Day = @birthDay,
                                            Phone_Number = @phoneNumber,
                                            Email = @email
                                        WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customer.Document_Number;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customer.First_Name;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customer.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.AddWithValue("@birthDay", SqlDbType.NVarChar).Value = customer.Birth_Day;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customer.Email;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = customer.Customer_Id;
                command.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los clientes
        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomersModel
                        {
                            Customer_Id = (int)reader["Customer_Id"],
                            Document_Number = reader["Document_Number"].ToString(),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Birth_Day = reader["Birth_Day"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customersList.Add(customer);
                    }
                }
            }

            return customersList;
        }

        // Método para buscar clientes por valor (documento o nombre)
        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string documentNumber = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer
                                        WHERE Customer_Id = @id OR Document_Number LIKE @documentNumber + '%'
                                        ORDER BY Customer_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = documentNumber;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomersModel
                        {
                            Customer_Id = (int)reader["Customer_Id"],
                            Document_Number = reader["Document_Number"].ToString(),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Birth_Day = reader["Birth_Day"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customersList.Add(customer);
                    }
                }
            }

            return customersList;
        }
    }
}
