

using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Collections.Generic;

namespace Accessories.Models
{
    public class Categories

    {
        string connStr = "server=localhost;user=root;database=accessories;password=root;";
        public void Cat(ref List<Two> listCategories)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"SELECT
                            ID,
                            NAME
                            FROM categories";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    //string[] people = array.Append(item);

                    listCategories.Add(new Two(id, name));

                }
            }


            conn.Close();

        }
        public void Attributes(ref List<Two> listAttributes, int id)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"SELECT
                            ID,
                            attribute_NAME
                            FROM attributes WHERE category_Id = "+ id+ " ";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id1 = (int)reader["id"];
                    string name = (string)reader["attribute_NAME"];
                    //string[] people = array.Append(item);

                    listAttributes.Add(new Two(id1, name));

                }
            }


            conn.Close();

        }
        public void AddCategory(string name)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"INSERT INTO CATEGORIES(NAME) VALUES('" + name + "')";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            command.ExecuteReader();
            


            conn.Close();

        }
    }
}