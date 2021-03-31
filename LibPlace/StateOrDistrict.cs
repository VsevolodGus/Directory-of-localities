using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibPlace
{
    public class StateOrDistrict : Place
    {
        protected string OlderPlace { get; }

        private readonly string Column;

        public StateOrDistrict(string Title, string Column, string OlderPlace) : base(Title)
        {
            this.OlderPlace = OlderPlace;
            this.Column = Column;
        }
        
        public override void Add(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [{Column}] (Title , OlderPlace) VALUES(N'{Title}' , N'{OlderPlace}')", DB);
                //command.Parameters.AddWithValue("Title", Title);
                //command.Parameters.AddWithValue("OlderPlace",OlderPlace);
            
            command.ExecuteNonQuery();
        }

        public override void Delete(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM {Column} WHERE (Title=N'{Title}' AND OlderPlace = N'{OlderPlace}')",DB);
            
            command.ExecuteNonQuery();
        }

        public static List<string> LoadListState(string Column, string OlderPlace, SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"SELECT Title FROM {Column} WHERE(OlderPlace = N'{OlderPlace}')" , DB);

            List<string> list = new List<string>();
            
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                reader.Close();

            return list;
        }
    }
}
