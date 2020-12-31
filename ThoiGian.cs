using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace _001_DETAI
{
    public class thoiGian
    {
        public Trua trua { get; set; }
        public Sang sang { get; set; }
        public Toi toi { get; set; }
        public thoiGian()
        {
           
        }
        public thoiGian(params int[] thamso)
        {
            this.sang.flag = thamso[0];
            this.trua.flag = thamso[1];
            this.toi.flag = thamso[2];
        }
    }
}