using System;
using System.Data.SqlClient;

namespace LibPlace
{
    public class Town : StateOrDistrict
    {
        private string Type { get; }
        public Town(string name,string column, string oldplace, string type) : base(name,column, oldplace)
        {
            this.Type = type;
        }
        public override void Add(SqlConnection DB )
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Town]  (Title,OlderPlace,Type) VALUES (@Title,@OlderPlace,@Type)");
            command.Parameters.AddWithValue("", this.Title);
            command.Parameters.AddWithValue("", this.OlderPlace);
            command.Parameters.AddWithValue("", this.Type);

            command.ExecuteNonQuery();
        }

        public override void Delete(string coulum, SqlConnection DB)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [@Coulumn] (Title,Type) VALUES(@Title) WHERE (Type = @Type)", DB);
            command.Parameters.AddWithValue("Column", coulum);
            command.Parameters.AddWithValue("Title", this.Title);
            command.Parameters.AddWithValue("Type", this.Type);

            command.ExecuteNonQuery();
        }


    }
}
