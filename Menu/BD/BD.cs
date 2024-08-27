using Menu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient

namespace Menu.BD
{
    internal class BD
    {
        private readonly string _connection;
        public string Connection => _connection;
        public BD()
        {
            _connection = @"Server=DESKTOP-LA6873F; Database=MenuManagement; Trusted_connection=true;";
        }

        internal ObservableCollection<MenuModel> Get() 
        {
            ObservableCollection<MenuModel> lstResult = new ObservableCollection<MenuModel>();
            string query = "SELECT * FROM Menu";
            using (SqlConnection cn = new SqlConnection(Connection))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstResult.Add(new MenuModel()
                    {
                        Id = (int)reader["ID"],
                        Name = (string)reader["Name"],
                        IsBreakfast = (bool)reader["ISBREAKFAST"],
                        IsDinner = (bool)reader["ISDINNER"],
                        IsLunch = (bool)reader["ISLUNCH"],
                        IsOther = (bool)reader["ISOTHER"],
                        IsSnack = (bool)reader["ISSNACK"],
                    });
                }
                reader.Close();
                cn.Close();
            }
            return lstResult;
        }
    }
}
