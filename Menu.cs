using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Menu
    {
        public Dictionary<int, Food> listMonAn;
        public Menu()
        {
            // chua danh sach mon an cua menu.sang
            //                               .trua
            //                               .toi
            Dictionary<int, Food> ListMonAn = new Dictionary<int, Food>(100);
        }

        private void InMenu(int a,int b,int c)
        {
            DataBase data = new DataBase();
            data.truyVanMonAn(a,b,c);
        }
        public delegate Food DelegateChonMon(int n);
        public delegate void DelegateIn();
        public Dictionary<int,Food> chonMon(DelegateChonMon upDateList)
        {
            Dictionary<int,Food> tempt = new Dictionary<int, Food>();
            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
                Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());
                tempt.Add(n,upDateList(n));
                /*upDateList(n);*/
            }
            return tempt;
        }
        public Food upDateList(int n)
        {
            DataBase a = new DataBase();
            if (a.dictionary_sang.ContainsKey(n))
            {
                // them vao List
                //this.listMonAn.Add(n,a.dictionary_sang[n]);
                return a.dictionary_sang[n];
            }
            if (a.dictionary_trua.ContainsKey(n))
            {
                // them vao List
                //this.listMonAn.Add(n,a.dictionary_trua[n]);
                return a.dictionary_trua[n];
            }
            if (a.dictionary_toi.ContainsKey(n))
            {
                // them vao List
                //this.listMonAn.Add(n,a.dictionary_toi[n]);
                return a.dictionary_toi[n];
            }
            return null;
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
            this.listMonAn = chonMon(upDateList);
                //chonMon(upDateList));
            suaDsMonAn(upDateList);

            return "hanhdong";
        }
    }
}
