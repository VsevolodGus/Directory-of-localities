using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibPlace
{
    public class Town : Place
    {
        protected string Type { get; }

        protected string OlderPlace { get; }

        public Town(string Title, string OlderPlace, string Type) : base(Title)
        { 
            this.OlderPlace = OlderPlace;
            this.Type = Type;
        }


        public override void Add(SqlConnection DB )
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Town] (Title, OlderPlace, Type) VALUES(N'{Title}', N'{OlderPlace}', N'{Type}')",
                                                DB);

            command.ExecuteNonQuery();
        }

        public override void Delete(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM Town " +
                                                $"WHERE (Title = N'{Title}' AND OlderPlace = N'{OlderPlace}' AND Type = N'{Type}')", DB);

            command.ExecuteNonQuery();
        }

        public static List<string> LoadListState(string OlderPlace,string Type, SqlConnection DB)
        {
            List<string> list = new List<string>();
            
            if (Type == "все")
            {
                SqlCommand command = new SqlCommand($"SELECT Title FROM Town WHERE(OlderPlace = N'{OlderPlace}')", DB);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                reader.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand($"SELECT Title FROM Town " +
                        $"WHERE(OlderPlace = N'{OlderPlace}' AND TYPE = N'{Type}')", DB);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                reader.Close();
            }
           
            return list;
        }
    }
}
