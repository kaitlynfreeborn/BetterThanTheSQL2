using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PizzaPickUp.Models;
using System.Configuration;

namespace PizzaPickUp.Models
{
    public class OrderBusinessLayer
    {

        public IEnumerable<PlaceOrder> Orders
        {
            get
            {
                String connstring = ConfigurationManager.ConnectionStrings["DORIBORN"].ConnectionString;
                List<PlaceOrder> ord = new List<PlaceOrder>();
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    SqlCommand cmd = new SqlCommand("Select * from PlaceOrder", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PlaceOrder order = new PlaceOrder();
                        order.OrderID = Convert.ToInt32(reader[0]);
                        order.Quantity = Convert.ToInt32(reader[1]);
                        order.Price = Convert.ToDouble(reader[2]);

                        ord.Add(order);
                    }
                    return ord;
                }
            }
        }

        public void addOrder(PlaceOrder ord)
        {
            string connString = ConfigurationManager.ConnectionStrings["DORIBORN"].ConnectionString;
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("spPlaceOrder", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter paramOrderID = new SqlParameter
                {
                    ParameterName = "@OrderID",
                    Value = ord.OrderID
                };
                cmd.Parameters.Add(paramOrderID);

                SqlParameter paramQuantity = new SqlParameter
                {
                    ParameterName = "@Quantity",
                    Value = ord.Quantity
                };
                cmd.Parameters.Add(paramQuantity);

                SqlParameter paramPrice = new SqlParameter
                {
                    ParameterName = "@Price",
                    Value = ord.Price
                };
                cmd.Parameters.Add(paramPrice);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}