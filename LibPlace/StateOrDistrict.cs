using System;
using System.Data.SqlClient;

namespace LibPlace
{
    public class StateOrDistrict : Country 
    {
        protected string OlderPlace { get; }

        private readonly string Column; 


        public StateOrDistrict(string Title, string Column, string OldPlace) : base(Title)
        {
            this.OlderPlace = OldPlace;
            this.Column = Column;
        }
        
        public override void Add(SqlConnection DB)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [@Column] (Title,OlderPlace) VALUES(@Title,@OlderPlace)", DB);
            command.Parameters.AddWithValue("Column", this.Column);
            command.Parameters.AddWithValue("Title", this.Title);
            command.Parameters.AddWithValue("OlderPlace",this.OlderPlace);
            command.ExecuteNonQuery();
        }
    }
}
