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
        public string InDSMonAn()
        {
            return "in";
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
        public void InMenu()
        {
            DataBase data = new DataBase();
            data.truyVanMonAn(0,1,1);
        }
        public void chonMon(Dictionary<int, Food> listMonAn)
        {
            int n = 0;
            while(n!= -1)
            {
                Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
                Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());
                upDateList(listMonAn,n);
            }
        }
        public void upDateList(Dictionary<int, Food> listMonAn,int n)
        {
            DataBase a = new DataBase();
            if (a.dictionary_sang.ContainsKey(n))
            {
                // them vao List
            }
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
        public string cacHanhDong(Dictionary<int,Food> listMonAn)
        {
            InMenu();
            chonMon(listMonAn);
            suaDsMonAn();// de sau

            return "hanhdong";
        }
    }
}
