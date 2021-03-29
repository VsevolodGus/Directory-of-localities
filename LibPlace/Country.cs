using System;
using System.Data.SqlClient;

namespace LibPlace
{
    public class Country 
    {
        protected int Id { get; }

        protected string Title { get; }
        
        public Country(string Title ) 
        {
            this.Title = Title;
        }

        // добавление страны в БД таблицу Country
        public virtual void Add(SqlConnection DB )
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Country] (Title) VALUES(@Title)", DB);
            command.Parameters.AddWithValue("Title" , this.Title );
            command.ExecuteNonQuery();
        }


        // удаление объекта из БД
        public virtual void Delete(string coulum, SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [@Coulumn] (Title) VALUES(@Title)", DB);
            command.Parameters.AddWithValue("Title", this.Title);
            command.Parameters.AddWithValue("Column", coulum);
            command.ExecuteNonQuery();
        }
    }
}
