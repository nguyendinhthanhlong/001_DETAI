﻿using System;
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
            /*Console.WriteLine("sang\n");
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
            }*/
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
