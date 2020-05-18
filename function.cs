

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Linq;


namespace HW22_14_05_2020
{
    class function
    {
        //Insert
        const string ConnectionString = @"Data Source=localhost;Initial Catalog=DapperShop;Integrated Security=True";
        public static void Add(Shop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query($"INSERT INTO  Shop (Company, Model) Values('{product.Company}','{product.Model}')");

            }


        }
        //Select
        public static List<T> Read<T>()
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<T>($"SELECT * FROM {typeof(T).Name?.ToUpper()}").ToList();
            }
        }

        //Update
        public static void Update(Shop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query<Shop> ($"Update Shop SET Company='{product.Company}', Model='{product.Model}' WHERE ID={product.Id}");
            }
        }

        //Delete
        public static void Delete(Shop product)
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                con.Query<Shop> ($"DELETE FROM Shop WHERE ID={product.Id}");
            }
        }
    }

    public partial class Shop
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
    }
}
