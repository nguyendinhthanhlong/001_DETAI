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
        
        public List<thoiGian> listTIME { get; set; }
        public Nguoi()
        {
            this.listTIME = new List<thoiGian>();
        }
        public Nguoi(Nguoi a)
        {
            this.listTIME = new List<thoiGian>();
            this.name = a.name;
            this.id = id;
            this.listTIME = a.listTIME;
        }
        public Nguoi(params object[] thongtin)
        {
            this.listTIME = new List<thoiGian>();
            this.name =(string)thongtin[0];
            this.id = (int)thongtin[1];
            this.listTIME = (List<thoiGian>)thongtin[2];
        }
    }
}
