using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Sang
    {
       public List<Food> listFoodSang;
       public int flag { get; set; }
        public Sang()
        {
            listFoodSang = new List<Food>();
            flag = 0;
        }
    }
}