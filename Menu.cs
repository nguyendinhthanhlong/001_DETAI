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
        public delegate void DelegateIn(Dictionary<int, Food> listCu);
        public Dictionary<int,Food> chonMon(DelegateChonMon upDateList)
        {
            Dictionary<int,Food> tempt = new Dictionary<int, Food>();
            int n;
            Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            while (n != -1)
            {
                tempt.Add(n, upDateList(n));
                Console.WriteLine("nhap mon can chon, khong chon nua thi nhap -1");
                Console.WriteLine("n = ");
                n = int.Parse(Console.ReadLine());
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
        public void InDsMonAn(DelegateIn Inds, Dictionary<int, Food> listCu)
        {
            Inds(listCu);
        }
        public void Inds(Dictionary<int, Food> list)
        {
            foreach (KeyValuePair<int, Food> d in list)
            {
                Console.WriteLine(d.Key + "  " + d.Value.tenMonAn + "  " + d.Value.loaiMonAn
                    + "  " + d.Value.kalo + "  " + d.Value.image + "  " + d.Value.giaTien);
            }
        }
        public Dictionary<int, Food> suaDsMonAn(Dictionary<int, Food> listCu)
        {
            Dictionary<int, Food> tempt = new Dictionary<int, Food>(listCu);
            int delete;
            Console.WriteLine("nhap mon can sua, khong sua nua thi nhap -1");
            Console.WriteLine(" n = ");
            delete = int.Parse(Console.ReadLine());
            while (delete != -1)
            {
                    tempt.Remove(delete);
                    Console.WriteLine("nhap mon can sua, khong sua nua thi nhap -1");
                    Console.WriteLine(" n = ");
                    delete = int.Parse(Console.ReadLine());
            }
            return tempt;
        }
        public string cacHanhDong()
        {
            InMenu(1,1,1);
            this.listMonAn = chonMon(upDateList);
            this.listMonAn = suaDsMonAn(listMonAn);
            Console.WriteLine("===========================================\ncac mon an cua ban la \n");
            InDsMonAn(Inds, listMonAn);
            Console.WriteLine("_________________________\n\n");
            return "hanhdong";
        }
    }
}
