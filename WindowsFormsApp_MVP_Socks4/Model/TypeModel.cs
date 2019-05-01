using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_MVP_Socks4.Model
{
    public class TypeModel
    {
        public int Id { set; get; }
        public string name;

        public string Name
        {
            set
            {
                this.name = value;
            }

            get
            {
                return this.name;
            }
        }
    }
}
