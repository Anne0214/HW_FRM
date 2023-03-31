using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_pose
{

    public class commodity
    {
        public int price;
        public string name;
        public int count;
    public commodity(int price, string name, int count)
        {
            this.price = price;
            this.name = name;
            this.count = count;
        }
    }
    
}

