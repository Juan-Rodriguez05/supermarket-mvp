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

        public void Add (ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void add(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = (int)reader["Product_Price"];
                        productModel.Product_Stock = (int)reader["Product_Stock"];
                        productModel.Category_Name = reader["Category_Name"].ToString();
                        productModel.Provider_Id = (int)reader["Provider_Id"];
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
                command.CommandText = @"SELECT * FROM Product 
                                        WHERE Product_Id=@id OR Product_Name LIKE '%' + @name + '%'";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_Id = (int)reader["Product_Id"];
                        productModel.Product_Name = reader["Product_Name"].ToString();
                        productModel.Product_Price = (int)reader["Product_Price"];
                        productModel.Product_Stock = (int)reader["Product_Stock"];
                        productModel.Category_Name = reader["Category_Name"].ToString();
                        productModel.Provider_Id = (int)reader["Provider_Id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;

        }
    }
}
