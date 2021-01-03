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
        public thoiGian thoigian { get; set; }
        
        public Nguoi()
        {
            this.thoigian = new thoiGian();
        }
        public Nguoi(Nguoi a)
        {
            this.name = a.name;
            this.id = id;
            this.thoigian.sang = a.thoigian.sang;
            this.thoigian.trua = a.thoigian.trua;
            this.thoigian.toi = a.thoigian.toi;
        }
        public Nguoi(params object[] thongtin)
        {
            this.name =(string)thongtin[0];
            this.id = (int)thongtin[1];
            this.thoigian.sang = (Sang)thongtin[2];
            this.thoigian.trua = (Trua)thongtin[3];
            this.thoigian.toi  = (Toi)thongtin[4];
        }
    }
}
