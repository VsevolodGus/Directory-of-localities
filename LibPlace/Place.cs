using System;
using System.Data.SqlClient;

namespace LibPlace
{
    public abstract class Place
    {
        protected string Name { get; }
        public Place(string name)
        {
            this.Name = name;
        }
        
        public abstract void Add(string title, SqlConnection DB);

        public void Delete(string coulumn, string title, SqlConnection DB)
        {
            throw new NotImplementedException();
        }
    }
}
