using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Musicshop.Models;

namespace Musicshop.DAL
{
    public class ProductSQLContext
    {
        public object GetProductById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                try
                {
                    Product product = new Product();
                    connection.Open();
                    SqlCommand sqlCom = connection.CreateCommand();

                    sqlCom.CommandText = @"SELECT * FROM [Product] WHERE productid = @id";
                    sqlCom.Parameters.Add("@id", SqlDbType.Int);
                    sqlCom.Parameters["@id"].Value = id;
                }
    }
}
