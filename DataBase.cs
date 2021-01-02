using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public abstract class ClassCha
    {
        
    }
    public class DataBase : ClassCha
    {
        public List<Food> listFood;
        Dictionary<int, Food> dictionary_sang = new Dictionary<int, Food>();
        Food sang_1 = new Food("loai", "ga", 100000, 300, "image1");
        Food sang_2 = new Food("loai", "com_trang", 100000, 300, "image2");
        Food sang_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");


        
        public DataBase()
        {

        }
        public DataBase(DataBase data)
        {
            this.listFood = new List<Food>();
            foreach(Food food in data.listFood) 
            {
                this.listFood.Add(food);
            }           
        }
        public DataBase(List<Food> food)
        {
            this.listFood = new List<Food>();
            foreach(Food monan in food)
            {
                this.listFood.Add(monan);
            }
        }

        public delegate object TruyVanHandel(params object[] thamso);
        public event TruyVanHandel truyVanEvent;
        
        protected string moKetNoi()
        {
            return "mo ket noi\n";
        }
        protected string dongKetNoi()
        {
            return "dong ket noi\n";
        }
        protected string chonTime()
        {
            return "chon mon\n";
        }
        protected string chonDinhDuong()
        {
            return "chon dinh duong";
        }
        protected string inRaManHinhList()
        {
            return "in ra man Hinh danh sach\n";
        }
        public string truyVanMonAn()
        {
            moKetNoi();
            chonTime();
            chonDinhDuong();
            //truyVanEvent.?Invoke("thasmo");
            inRaManHinhList();
            dongKetNoi();

            return "chon xong roi\n";
        }
    }
}
