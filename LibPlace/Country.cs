using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibPlace
{
    public class Country : Place
    {

        public Country(string Title) : base(Title) { }

        
        // public static List<Country> ReturnListPlace(string Column, SqlConnection DB) => ReturnListForReader(Column, DB);

        //protected virtual List<Country> ReturnListForReader(string Column,SqlConnection DB)
        //{
        //    SqlCommand command = new SqlCommand("SELECT * FROM @Column", DB);
        //    List<Country> listRange = new List<Country>();
        //    SqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Country country = new Country(reader.GetInt32(0) ,reader.GetString(1));
        //        listRange.Add(country);
        //    }
        //    reader.Close();
        //    return listRange;
        //}


        // добавление страны в БД таблицу Country
        
        public override void Add(SqlConnection DB )
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Country] (Title) VALUES(@Title)", DB);
                command.Parameters.AddWithValue("Title" , this.Title );
            
            command.ExecuteNonQuery();
        }


        // удаление объекта из БД
        public override void Delete(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Country WHERE Title = @Title", DB);
                command.Parameters.AddWithValue("Title", this.Title);

            command.ExecuteNonQuery();
        }

        public static List<string> LoadList(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Country", DB);
            //command.Parameters.AddWithValue("Column", Column);    

            List<string> list = new List<string>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(1));
            }

            reader.Close();

            return list;
        }
    }
}
