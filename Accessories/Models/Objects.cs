using Org.BouncyCastle.Asn1.Cms;

namespace Accessories.Models
{
    public class Objects
    {

        string connStr = "server=localhost;user=root;database=accessories;password=root;";
        public void Obj(ref List<Six> listObjects)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = @"SELECT objects.name, objects.price, objects.about,objects.category_id, categories.id, categories.name as category,
         GROUP_CONCAT(objects.attribute_name SEPARATOR ',') AS attributes
    FROM objects, categories WHERE objects.category_Id = categories.id
GROUP BY objects.name";
            // объект для выполнения SQL-запроса
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    string name = (string)reader["name"];

                    int category_Id = (int)reader["category_id"];
                    string category = (string)reader["category"];
                    int price =(int)reader["price"];
                    string about = (string)reader["about"];
                    string attributes = (string)reader["attributes"];
                    listObjects.Add(new Six(name, category_Id, category, price, about, attributes));

                }
            }


            conn.Close();

        }
    }
}
