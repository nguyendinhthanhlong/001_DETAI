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
    public enum time
    {
        sang,trua,toi
    }
    public enum luong
    {
        it,nhieu,vua
    }
    public class Food
    {
        public string tenMonAn { get; set; }
        public int giaTien { get; set; }
        public int kalo { get; set; }
        public time thoiGian { get; set; }
        public dinhduong dinhDuong { get; set; }
        public string image { get; set; }
        public Food()
        {

        }
        public Food(Food food)
        {
            this.giaTien = food.giaTien;
            this.kalo = food.kalo;
            this.tenMonAn = food.tenMonAn;
            this.dinhDuong = food.dinhDuong;
            this.thoiGian = food.thoiGian;
        }
        public Food(string ten, int gia, int kalo,dinhduong dinh,time thoi)
        {
            this.tenMonAn = ten;
            this.giaTien = gia;
            this.kalo = kalo;
            this.dinhDuong = dinh;
            this.thoiGian = thoi;
        }
        public Food(params object[] mon)
        {
            this.tenMonAn = (string)mon[0];
            this.giaTien = (int)mon[1];
            this.kalo = (int)mon[2];
            //
        }    
    }
}
