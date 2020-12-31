using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public abstract class BaseClass
    {

    }
    public class Nguoi:BaseClass
    {
        public string name { get; set; }
        public int id { get; set; }
        public List<Food> listMonAn;
        public Nguoi()
        {
            this.
            this.listMonAn = new List<Food>();
        }
        public Nguoi(Nguoi a)
        {
            this.name = a.name;
            this.id = id;
        }
        public Nguoi(params object[] thongtin)
        {
            this.name =(string)thongtin[0];
            this.id = (int)thongtin[1];
        }


    }
}
