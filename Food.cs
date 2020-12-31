using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public enum dinhduong
    {
        tinhbot,chatbeo,dam,vitamin_khoang
    }

    public enum luong
    {
        it,nhieu,vua
    }
    public class Food
    {
        public string loaiMonAn { get; set;}
        public string tenMonAn { get; set; }
        public int giaTien { get; set; }
        public int kalo { get; set; }
        
        public dinhduong dinhDuong { get; set; }
        public string image { get; set; }
        public Food()
        {

        }
        public Food(Food food)
        {
            this.loaiMonAn = food.loaiMonAn;
            this.giaTien = food.giaTien;
            this.kalo = food.kalo;
            this.tenMonAn = food.tenMonAn;
            this.dinhDuong = food.dinhDuong;
        }
        public Food(string ten, int gia, int kalo,dinhduong dinh,time thoi,string loai)
        {
            this.loaiMonAn = loai;
            this.tenMonAn = ten;
            this.giaTien = gia;
            this.kalo = kalo;
            this.dinhDuong = dinh;

        }
        public Food(params object[] mon)
        {
            this.loaiMonAn = (string)mon[0];
            this.tenMonAn = (string)mon[1];
            this.giaTien = (int)mon[2];
            this.kalo = (int)mon[3];
            //
        }    
    }
}
//