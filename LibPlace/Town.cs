using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPlace
{
    public class Town : Place
    {
        protected string OlderPlace { get; }

        protected string TypePlace { get; } 
        public override void Add()
        {
            throw new NotImplementedException();
        }
    }
}
