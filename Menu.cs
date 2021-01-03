using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Menu
    {
        public Dictionary<int, Food> listMonAn { get; set; }
        public Menu()
        {
            Dictionary<int, Food> ListMonAn = new Dictionary<int, Food>();
        }

        private void InMenu(int a,int b,int c)
        {
            DataBase data = new DataBase();
            data.truyVanMonAn(a,b,c);
        }
        public delegate void DelegateChonMon(int n);
        public delegate void DelegateIn();
        public void chonMon(DelegateChonMon upDateList)
        {
            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
                Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());
                upDateList(n);
            }
        }
        public void upDateList(int n)
        {
            DataBase a = new DataBase();
            if (a.dictionary_sang.ContainsKey(n))
            {
                // them vao List
                this.listMonAn[n] = a.dictionary_sang[n];
            }
            if (a.dictionary_trua.ContainsKey(n))
            {
                // them vao List
                this.listMonAn[n] = a.dictionary_trua[n];
            }
            if (a.dictionary_toi.ContainsKey(n))
            {
                // them vao List
                this.listMonAn[n] = a.dictionary_toi[n];
            }
        }
        public void InDsMonAn(DelegateIn Inds)
        {
            Inds();
        }
        private void Inds()
        {
            foreach (KeyValuePair<int, Food> dictionary in this.listMonAn)
            {
                Console.WriteLine(dictionary.Key + "  " + dictionary.Value.tenMonAn + "  " + dictionary.Value.loaiMonAn
                    + "  " + dictionary.Value.kalo + "  " + dictionary.Value.image + "  " + dictionary.Value.giaTien);
            }
        }
        public void suaDsMonAn(DelegateChonMon Fix)
        {

            InDsMonAn(Inds);

            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("nhap mon can sua, khong sua nua thi nhap -1");
                Console.WriteLine(" n = ");
                int delete = int.Parse(Console.ReadLine());
                Fix(delete);
            }
            chonMon(upDateList);
        }
        private void Fix(int delete) 
        {
            this.listMonAn.Remove(delete);
        }
        public string cacHanhDong()
        {
            InMenu(1,1,1);
            chonMon(upDateList);
            suaDsMonAn(upDateList);

            return "hanhdong";
        }
    }
}
