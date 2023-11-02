


using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Accessories.Models
{
    public class Attributes
    {
        

string connStr = "server=localhost;user=root;database=accessories;password=root;";
        public void Att(ref List<Three> listAttributes, int id_)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"SELECT
                            ID,
                            ATTRIBUTE_NAME,
                            CATEGORY_ID
                            FROM attributes where category_Id ="+id_+" ";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["ATTRIBUTE_NAME"];
                    
                    int category_Id = (int)reader["category_Id"];

                    listAttributes.Add(new Three(id, name,category_Id));

                }
            }


            conn.Close();

        }
        
            public void AddAttribute(string name , int category_id)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"INSERT INTO ATTRIBUTES(ATTRIBUTE_NAME, CATEGORY_ID) VALUES('" + name + "','" + category_id + "' )";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            command.ExecuteReader();
           


            conn.Close();

        }
    }
}
