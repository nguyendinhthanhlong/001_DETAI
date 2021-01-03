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
            this.sang = new Sang();
            this.trua = new Trua();
            this.toi = new Toi();
        }
        public thoiGian(params int[] thamso)
        {
            this.sang = new Sang();
            this.trua = new Trua();
            this.toi = new Toi();
            
        }
    }
}