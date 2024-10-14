using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Collections.Generic;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoryList = new List<CategoriesModel>();
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
                        var categoryModel = new CategoriesModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoryList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category 
                                         WHERE Category_Name LIKE @value + '%' 
                                         OR Description LIKE @value + '%'
                                         ORDER BY Category_Id DESC";
                command.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoriesModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public void Add(CategoriesModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Category (Category_Name, Description) 
                                        VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = category.Description;
                command.ExecuteNonQuery();
            }
        }

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
    }
}
