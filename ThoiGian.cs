using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace _001_DETAI
{
    public class ThoiGian 
    {

        public Trua trua { get; set; }
        public Sang sang { get; set; }
        public Toi toi { get; set; }
        public ThoiGian()
        {
            this.sang = new Sang();
            this.trua = new Trua();
            this.toi = new Toi();
        }
        public ThoiGian(params int[] thamso)
        {
            this.sang = new Sang();
            this.trua = new Trua();
            this.toi = new Toi();
            
        }
    }
}