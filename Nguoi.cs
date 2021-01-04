using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _001_DETAI
{
    public abstract class BaseClass
    {
        // cho param la de add 1 list luon
    }
    public class Nguoi:BaseClass
    {
        public string name { get; set; }
        public int id { get; set; }
        
        public List<ThoiGian> listTIME { get; set; }
        // mac dinh la co ngay 0-99 : 100 ngay chua co thong tin mon an
        public Nguoi()
        {
            this.listTIME = new List<ThoiGian>();
            for(int i = 0; i < 100; i++)
            {
                ThoiGian a = new ThoiGian();
                this.listTIME.Add(a);
            }
        }
        public Nguoi(Nguoi a)
        {
            this.listTIME = new List<ThoiGian>();
            this.name = a.name;
            this.id = id;
            this.listTIME = a.listTIME;
        }
        public Nguoi(params object[] thongtin)
        {
            this.listTIME = new List<ThoiGian>();
            this.name =(string)thongtin[0];
            this.id = (int)thongtin[1];
            this.listTIME = (List<ThoiGian>)thongtin[2];
        }
    }
}
