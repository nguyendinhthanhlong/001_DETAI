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
            DataBase data = new DataBase();
            data.truyVanMonAn(1, 1, 1);
            Nguoi nguoi1= new Nguoi();
         
            Menu menu = new Menu();
            menu.cacHanhDong(nguoi1.listTIME[1].sang.ListMonAn);
        }
    }
}