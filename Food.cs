using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Food
    {
        public string loaiMonAn { get; set;}
        public string tenMonAn { get; set; }
        public int giaTien { get; set; }
        public int kalo { get; set; }
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
        }
        public Food(string loai,string ten, int gia, int kalo,string image)
        {
            this.loaiMonAn = loai;
            this.tenMonAn = ten;
            this.giaTien = gia;
            this.kalo = kalo;
            this.image = image;
        }
        public Food(params object[] mon)
        {
            int count = mon.Length - 1;
            Console.WriteLine(count);
            if (count == 0)
            {
                this.loaiMonAn = (string)mon[0];
            }
            if (count == 1)
            {
                this.loaiMonAn = (string)mon[0];
                this.tenMonAn = (string)mon[1];
            }

            if (count == 2)
            {
                this.loaiMonAn = (string)mon[0];
                this.tenMonAn = (string)mon[1];
                this.giaTien = (int)mon[2];
            }

            if (count == 3)
            {
                this.loaiMonAn = (string)mon[0];
                this.tenMonAn = (string)mon[1];
                this.giaTien = (int)mon[2];
                this.kalo = (int)mon[3];
            }

            if (count == 4)
            {
                this.loaiMonAn = (string)mon[0];
                this.tenMonAn = (string)mon[1];
                this.giaTien = (int)mon[2];
                this.kalo = (int)mon[3];
                this.image = (string)mon[4];
            }
        }    
    }
}
