using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class ClassCha: IDictionary
    {

        public Dictionary<int, Food> dictionary_sang = new Dictionary<int, Food>();
        public Dictionary<int, Food> dictionary_trua = new Dictionary<int, Food>();
        public Dictionary<int, Food> dictionary_toi = new Dictionary<int, Food>();

        Dictionary<int, Food> IDictionary.dictionary_sang { get; set; }
        Dictionary<int, Food> IDictionary.dictionary_trua { get; set; }
        Dictionary<int, Food> IDictionary.dictionary_toi { get; set; }

        public ClassCha()
        {
            Food sang_1 = new Food("loai", "ga", 100000, 300, "image1");
            Food sang_2 = new Food("loai", "com_trang", 100000, 300, "image2");
            Food sang_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

            Food trua_1 = new Food("loai", "ga", 100000, 300, "image1");
            Food trua_2 = new Food("loai", "com_trang", 100000, 300, "image2");
            Food trua_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

            Food toi_1 = new Food("loai", "ga", 100000, 300, "image1");
            Food toi_2 = new Food("loai", "com_trang", 100000, 300, "image2");
            Food toi_3 = new Food("loai", "canh nuoc", 100000, 300, "image3");

            dictionary_sang.Add(1, sang_1);
            dictionary_sang.Add(2, sang_2);
            dictionary_sang.Add(3, sang_3);

            dictionary_trua.Add(1, sang_1);
            dictionary_trua.Add(2, trua_2);
            dictionary_trua.Add(3, sang_3);

            dictionary_toi.Add(1, trua_1);
            dictionary_toi.Add(2, trua_2);
            dictionary_toi.Add(3, trua_3);
        }

    }
    public class DataBase : ClassCha
    {
        public DataBase()
        {
            
        }
        public DataBase(DataBase data)
        {
                  
        }
        public DataBase(List<Food> food)
        {
            /*this.listFood = new List<Food>();
            foreach(Food monan in food)
            {
                this.listFood.Add(monan);
            }*/
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
            //chonTime();
            //truyVanEvent.?Invoke("thasmo");
            inRaManHinhList();
            dongKetNoi();

            return "chon xong roi\n";
        }
    }
}
