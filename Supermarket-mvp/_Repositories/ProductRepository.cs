using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Método para agregar un nuevo producto
        public void Add(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Product (Product_Name, Product_Price, Product_Stock, Category_Id)
                                        VALUES (@name, @price, @stock, @categoryId)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = product.ProductName;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = product.ProductPrice;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = product.ProductStock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = product.CategoryId;
                command.ExecuteNonQuery();
            }
        }

        // Método para eliminar un producto por su Id
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        // Método para editar un producto existente
        public void Edit(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product
                                        SET Product_Name = @name,
                                            Product_Price = @price,
                                            Product_Stock = @stock,
                                            Category_Id = @categoryId
                                        WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = product.ProductName;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = product.ProductPrice;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = product.ProductStock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = product.CategoryId;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = product.ProductId;
                command.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los productos
        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            ProductId = (int)reader["Product_Id"],
                            ProductName = reader["Product_Name"].ToString(),
                            ProductPrice = (decimal)reader["Product_Price"],
                            ProductStock = (int)reader["Product_Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }

        // Método para buscar productos por categoría o valor
        public IEnumerable<ProductModel> GetByCategory(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                        WHERE Product_Id = @id OR Product_Name LIKE @name + '%'
                                        ORDER BY Product_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = productId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            ProductId = (int)reader["Product_Id"],
                            ProductName = reader["Product_Name"].ToString(),
                            ProductPrice = (decimal)reader["Product_Price"],
                            ProductStock = (int)reader["Product_Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }
    }
}
