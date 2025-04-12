using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
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

        public void add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Product 
                                        VALUES (@Product_Name)";
                command.Parameters.Add("@Product_name", SqlDbType.NVarChar).Value = productModel.Product_Name;
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
                command.CommandText = @"DELETE FROM Product 
                                        WHERE Product_Id=@Product_id";
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
                command.CommandText = @"UPDATE PayMode 
                                        SET Product_Name=@Prouct_Name, Product_Price=@Product_Price, Product_Stock=@Product_Stock, Category_Name=@Category_Name, Provider_Id=@Provider_Id
                                        WHERE Product_Id=@id";
                command.Parameters.Add("@Product_id", SqlDbType.Int).Value = productModel.Product_Id;
                command.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = productModel.Product_Name;
                command.Parameters.Add("@Product_price", SqlDbType.Int).Value = productModel.Product_Price;
                command.Parameters.Add("@Product_stock", SqlDbType.Int).Value = productModel.Product_Stock;
                command.Parameters.Add("@Category_name", SqlDbType.NVarChar).Value = productModel.Category_Name;
                command.Parameters.Add("@Provider_id", SqlDbType.Int).Value = productModel.Provider_Id;
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
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = "Product_Price".ToString();
                        productModel.Product_Stock = "Product_Stock".ToString();
                        productModel.Category_Name = reader["Category_Name"].ToString();
                        productModel.Provider_Id = "Provider_Id".ToString();
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            string productName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product 
                                        WHERE Product_Id=@id OR Product_Name LIKE '%' + @name + '%'";
                command.Parameters.Add("@product_Name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = reader["Product_Price"].ToString();
                        productModel.Product_Stock = reader["Product_Stock"].ToString();
                        productModel.Category_Name = reader["Category_Name"].ToString();
                        productModel.Provider_Id = reader["Provider_Id"].ToString();
                        productList.Add(productModel);
                    }
                }
            }
            return productList;

        }
    }
}
