using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPlace
{
    public abstract class  Place
    {
        protected string  Title { get; }       

        public Place(string Title)
        {
            this.Title = Title;
        }

        public abstract void Add(SqlConnection DB);

        public abstract void Delete(SqlConnection DB);

       
    }
}
