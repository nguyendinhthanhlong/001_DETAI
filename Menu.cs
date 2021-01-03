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
        
        private void InMenu(int a,int b,int c)
        {
            DataBase data = new DataBase();
            data.truyVanMonAn(a,b,c);
        }
        public delegate void DelegateChonMon(Dictionary<int, Food> listMonAn, int n);
        public delegate void DelegateIn(Dictionary<int, Food> listMonAn);
        private void chonMon(DelegateChonMon upDateList, Dictionary<int, Food> listMonAn)
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
        private void upDateList(Dictionary<int, Food> listMonAn,int n)
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
        private void InDsMonAn(DelegateIn Inds, Dictionary<int, Food> listMonAn)
        {
            Inds(listMonAn);
        }
        private void Inds(Dictionary<int, Food> listMonAn)
        {
            foreach (KeyValuePair<int, Food> dictionary in listMonAn)
            {
                Console.WriteLine(dictionary.Key + "  " + dictionary.Value.tenMonAn + "  " + dictionary.Value.loaiMonAn
                    + "  " + dictionary.Value.kalo + "  " + dictionary.Value.image + "  " + dictionary.Value.giaTien);
            }
        }
        private void suaDsMonAn(DelegateChonMon Fix,Dictionary<int,Food> listMonAn)
        {

            InDsMonAn(Inds, listMonAn);

            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("nhap mon can sua, khong sua nua thi nhap -1");
                Console.WriteLine(" n = ");
                int delete = int.Parse(Console.ReadLine());
                Fix(listMonAn, delete);
            }

        }
        private void Fix(Dictionary<int, Food> listMonAn, int delete) 
        {
            listMonAn.Remove(delete);
        }
        public string cacHanhDong(Dictionary<int,Food> listMonAn)
        {
            InMenu(1,1,1);
            chonMon(upDateList,listMonAn);
            suaDsMonAn(upDateList,listMonAn);

            return "hanhdong";
        }
    }
}
