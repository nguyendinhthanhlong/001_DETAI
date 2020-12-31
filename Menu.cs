using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Menu
    {
        public enum thoigian{
            sang, trua, toi
        }
        public Menu()
        {

        }
        public string InDSMonAn()
        {
            return "in";
        }
        public thoigian chonThoiGian()
        {
            return (thoigian)1;
        }
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
        public string InMenu()
        {
            return "";
        }
        public string ThemVaoMenu()
        {
            return "";
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
            InDSMonAn(); // de sau
            thoigian thoigian = chonThoiGian();
            int soMon = chonSoMon(thoigian);
            string loai = chonLoai(soMon);

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
