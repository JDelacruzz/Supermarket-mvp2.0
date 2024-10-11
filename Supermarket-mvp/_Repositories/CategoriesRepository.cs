using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Supermarket_mvp.Models;

namespace Supermarket_mvp._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para agregar una nueva categoría
        public void Add(CategoriesModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Category 
                                        (Category_Name, Description)
                                        VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = category.Description;
                command.ExecuteNonQuery();
            }
        }

        // Método para eliminar una categoría por su ID
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Category WHERE Category_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        // Método para editar una categoría existente
        public void Edit(CategoriesModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Category
                                        SET Category_Name = @name,
                                            Description = @description
                                        WHERE Category_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = category.Description;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = category.Id;
                command.ExecuteNonQuery();
            }
        }

        // Método para obtener todas las categorías
        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoriesList = new List<CategoriesModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY Category_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoriesModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoriesList.Add(category);
                    }
                }
            }

            return categoriesList;
        }

        // Método para buscar categorías por valor (nombre o descripción)
        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriesModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHERE Category_Id = @id OR Category_Name LIKE @name + '%'
                                        ORDER BY Category_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoriesModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoriesList.Add(category);
                    }
                }
            }

            return categoriesList;
        }
    }
}
