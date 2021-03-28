using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPlace
{
    public  abstract class Place
    {
        protected string Name { get; }

        public abstract void Add();

        public void Delete() { }
    }
}
