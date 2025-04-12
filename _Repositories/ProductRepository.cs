using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Products 
                                        (Product_Name, Product_Price, Product_Stock, Category_Name, Provider_Id)
                                        VALUES (@Product_Name, @Product_Price, @Product_Stock, @Category_Name, @Provider_Id)";
                command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = productModel.Product_Name;
                command.Parameters.Add("@Product_Price", SqlDbType.Int).Value = productModel.Product_Price;
                command.Parameters.Add("@Product_Stock", SqlDbType.Int).Value = productModel.Product_Stock;
                command.Parameters.Add("@Category_Name", SqlDbType.NVarChar).Value = productModel.Category_Name;
                command.Parameters.Add("@Provider_Id", SqlDbType.Int).Value = productModel.Provider_Id;
                command.ExecuteNonQuery();
            }
        }

        public void delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Products WHERE Product_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products 
                                        SET Product_Name=@Product_Name, 
                                            Product_Price=@Product_Price, 
                                            Product_Stock=@Product_Stock, 
                                            Category_Name=@Category_Name, 
                                            Provider_Id=@Provider_Id
                                        WHERE Product_Id=@Product_Id";
                command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = productModel.Product_Id;
                command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = productModel.Product_Name;
                command.Parameters.Add("@Product_Price", SqlDbType.Int).Value = productModel.Product_Price;
                command.Parameters.Add("@Product_Stock", SqlDbType.Int).Value = productModel.Product_Stock;
                command.Parameters.Add("@Category_Name", SqlDbType.NVarChar).Value = productModel.Category_Name;
                command.Parameters.Add("@Provider_Id", SqlDbType.Int).Value = productModel.Provider_Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel
                        {
                            Product_Id = (int)reader["Product_Id"],
                            Product_Name = reader["Product_Name"].ToString(),
                            Product_Price = (int)reader["Product_Price"],
                            Product_Stock = (int)reader["Product_Stock"],
                            Category_Name = reader["Category_Name"].ToString(),
                            Provider_Id = (int)reader["Provider_Id"]
                        };
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                        WHERE Product_Id=@id OR Product_Name LIKE @name + '%'";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel
                        {
                            Product_Id = (int)reader["Product_Id"],
                            Product_Name = reader["Product_Name"].ToString(),
                            Product_Price = (int)reader["Product_Price"],
                            Product_Stock = (int)reader["Product_Stock"],
                            Category_Name = reader["Category_Name"].ToString(),
                            Provider_Id = (int)reader["Provider_Id"]
                        };
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
