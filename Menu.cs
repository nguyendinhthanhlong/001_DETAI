using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Menu
    {
        Dictionary<int, Food> dictionary_sang = new Dictionary<int, Food>();
        Dictionary<int, Food> dictionary_trua = new Dictionary<int, Food>();
        Dictionary<int, Food> dictionary_toi = new Dictionary<int, Food>();
        Food sang_1 = new Food("loai", "ga", 100000, 300, "image1");
        Food sang_2 = new Food("loai", "com_trang", 100000, 300, "image2");
        Food sang_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

        Food trua_1 = new Food("loai", "ga", 100000, 300, "image1");
        Food trua_2 = new Food("loai", "com_trang", 100000, 300, "image2");
        Food trua_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

        Food toi_1 = new Food("loai", "ga", 100000, 300, "image1");
        Food toi_2 = new Food("loai", "com_trang", 100000, 300, "image2");
        Food toi_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

        public Menu()
        {
            dictionary_sang.Add(1, sang_1);
            dictionary_sang.Add(2, sang_2);
            dictionary_sang.Add(3, sang_3);

            dictionary_trua.Add(1, trua_1);
            dictionary_trua.Add(2, trua_2);
            dictionary_trua.Add(3, trua_3);

            dictionary_toi.Add(1, toi_1);
            dictionary_toi.Add(2, toi_2);
            dictionary_toi.Add(3, toi_3);
        }
        public string InDSMonAn()
        {
            return "in";
        }
       /* public thoiGian chonThoiGian()
        {
            thoiGian time = new thoiGian();
           new sang();
            return  ;
        }*/
        public int chonSoMon(params object[] thamso)
        {
            return 4;
        }
        public string chonLoai(params object[] thamso)
        {
            return "chon loai";
        }
        public string themVaoDsMonAn()
        {
            //them 
            return "Add themVaoDsMonAn";
        }
        public string Fix(int Fix)
        {
            return "fix";
        }
        public void InMenu()
        {
            Console.WriteLine("sang\n");
            foreach(KeyValuePair<int,Food> bien in dictionary_sang)
            {
                Console.WriteLine(bien.Key + " : " + bien.Value.loaiMonAn + "  " + bien.Value.tenMonAn + "  " + bien.Value.giaTien + "  " + bien.Value.kalo + "  " + bien.Value.image);
            }
            Console.WriteLine("trua\n");
            foreach (KeyValuePair<int, Food> bien in dictionary_trua)
            {
                Console.WriteLine(bien.Key + " : " + bien.Value.loaiMonAn + "  " + bien.Value.tenMonAn + "  " + bien.Value.giaTien + "  " + bien.Value.kalo + "  " + bien.Value.image);
            }
            Console.WriteLine("toi\n");
            foreach (KeyValuePair<int, Food> bien in dictionary_toi)
            {
                Console.WriteLine(bien.Key + " : " + bien.Value.loaiMonAn + "  " + bien.Value.tenMonAn + "  " + bien.Value.giaTien + "  " + bien.Value.kalo + "  " + bien.Value.image);
            }
        }
        public void ThemVaoMenu()
        {
            
        }
        public string suaDsMonAn()
        {
            InMenu();
            Console.WriteLine("chon loai mon an can sua :\n");
            int fix = int.Parse(Console.ReadLine());
            Fix(fix);
            InMenu();
            return "";
        }
        public string cacHanhDong()
        {
            InDSMonAn(); // de sau //ok
            //ThoiGian thoigian = chonThoiGian();
            //int soMon = chonSoMon(thoigian);
            string loai = chonLoai(4);
            //chonMon();
            themVaoDsMonAn();
            suaDsMonAn();// de sau

            return "hanhdong";
        }
        /*public static Food operator +(Food food1, Food food2)
        {
            Food kq = new Food();
            kq.giaTien = food1.giaTien + food2.giaTien;
            return kq;
        }*/



        /*public string hoatDong()
        {
            In();
            chonTime();
            chonSoMon();
            chonloai();
            return ;
        }*/
    }
}
