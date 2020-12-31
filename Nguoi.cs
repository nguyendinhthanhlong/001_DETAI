using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public enum time
    {
        sang, trua, toi
    }
    public abstract class BaseClass
    {

    }
    public class Nguoi:BaseClass
    {
        public string name { get; set; }
        public int id { get; set; }
        public time thoiGian { get; set; }
        public List<Food> listMonAn;
        public Nguoi()
        {
            this.listMonAn = new List<Food>();
        }
        public Nguoi(Nguoi a)
        {
            this.name = a.name;
            this.thoiGian = thoiGian;
            this.id = id;
        }
        public Nguoi(params object[] thongtin)
        {
            this.name =(string)thongtin[0];
            this.thoiGian = (time)thongtin[1];
            this.id = (int)thongtin[2];
        }


    }
}
