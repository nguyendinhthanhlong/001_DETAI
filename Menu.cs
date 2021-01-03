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
        
        public void InMenu()
        {
            DataBase data = new DataBase();
            data.truyVanMonAn(0,1,1);
        }
        public delegate void DelegateChonMon(Dictionary<int, Food> listMonAn, int n);

        public void chonMon(DelegateChonMon upDateList, Dictionary<int, Food> listMonAn)
        {
            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
                Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());
                upDateList(listMonAn, n);
            }
        }
        public void upDateList(Dictionary<int, Food> listMonAn,int n)
        {
            DataBase a = new DataBase();
            if (a.dictionary_sang.ContainsKey(n))
            {
                // them vao List
                listMonAn[n] = a.dictionary_sang[n];
            }
            if (a.dictionary_trua.ContainsKey(n))
            {
                // them vao List
                listMonAn[n] = a.dictionary_trua[n];
            }
            if (a.dictionary_toi.ContainsKey(n))
            {
                // them vao List
                listMonAn[n] = a.dictionary_toi[n];
            }
        }
        public void suaDsMonAn(DelegateChonMon upDateList,Dictionary<int,Food> ListMonAn)
        {
            InDsList(ListMonAn);
            Console.WriteLine("chon loai mon an can sua :\n");
            int fix = int.Parse(Console.ReadLine());
            

            
        }
        public string cacHanhDong(Dictionary<int,Food> listMonAn)
        {
            InMenu();
            chonMon(upDateList,listMonAn);
            suaDsMonAn(upDateList,listMonAn);//dang lam

            return "hanhdong";
        }
    }
}
