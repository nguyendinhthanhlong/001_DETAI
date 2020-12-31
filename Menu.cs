using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Menu
    {
        public Menu()
        {

        }
        public string InMonAn()
        {
            return "in";
        }
        public string chonTime()
        {
            return "hoat dong : Chon Time ";
        }
        public string chonSoMon()
        {
            return "cho so mon";
        }
        public string chonloai()
        {
            return "chon loai";
        }
        public string themVaMenu()
        {
            //them 
            return "Add Meunu";
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
        public string suaMenu()
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
            InMonAn();
            string time = chonTime();
            string soMon = chonSoMon();
            string loai = chonloai();

            ThemVaoMenu();
            suaMenu();

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
