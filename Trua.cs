using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Trua
    {
        public Dictionary<int, Food> ListMonAn = new Dictionary<int, Food>();
        public int flag { get; set; }
        public Trua()
        {
            flag = 0;
        }
    }
}
