using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    class Program 
    {
        static void Main(string[] args)
        {
            Nguoi nguoi1= new Nguoi();
            Console.WriteLine("nhap ngay can chon mon an ");
            int ngay = int.Parse(Console.ReadLine());
/*
            Console.WriteLine("chon buoi sang");
            nguoi1.listTIME[ngay].sang.menu.cacHanhDong();

            Console.WriteLine("chon buoi trua");
            nguoi1.listTIME[ngay].trua.menu.cacHanhDong();*/

            Console.WriteLine("chon buoi toi");
            nguoi1.listTIME[ngay].toi.menu.cacHanhDong();

            InDsList(nguoi1.listTIME[ngay].toi.menu.listMonAn);

        }
        public static void InDsList(Dictionary<int, Food> list)
        {
            foreach (KeyValuePair<int, Food> d in list)
            {
                Console.WriteLine(d.Key + "  " + d.Value.tenMonAn + "  " + d.Value.loaiMonAn
                    + "  " + d.Value.kalo + "  " + d.Value.image + "  " + d.Value.giaTien);
            }
        }
    }
}