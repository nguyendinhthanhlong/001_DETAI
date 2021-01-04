using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public abstract class ClassCha: IDictionary
    {

        public Dictionary<int, Food> dictionary_sang = new Dictionary<int, Food>();
        public Dictionary<int, Food> dictionary_trua = new Dictionary<int, Food>();
        public Dictionary<int, Food> dictionary_toi = new Dictionary<int, Food>();

        Dictionary<int, Food> IDictionary.dictionary_sang { get; set; }
        Dictionary<int, Food> IDictionary.dictionary_trua { get; set; }
        Dictionary<int, Food> IDictionary.dictionary_toi { get; set; }

        public ClassCha()
        {
           
        }
    }
    public class DataBase : ClassCha
    {

        public DataBase()
        {
            Food sang_1 = new Food("thit", "ga_kho1", 20000, 100, "image1");
            Food sang_2 = new Food("com", "com_trang1", 2000, 200, "image2");
            Food sang_3 = new Food("canh", "canh rau 1", 100000, 300, "image3");
            Food sang_4 = new Food("rau_cu", "sup lo xao1", 100000, 50, "image4");
            Food sang_5 = new Food("ca", "ca_ngu1", 100000, 300, "image5");

            Food trua_1 = new Food("thit", "ga_kho2", 10000, 500, "image6");
            Food trua_2 = new Food("com", "com_trang2", 12000, 500, "image7");
            Food trua_3 = new Food("canh", "canh rau 2", 13000, 100, "image8");
            Food trua_4 = new Food("rau_cu", "rau muong", 7000, 300, "image9");
            Food trua_5 = new Food("ca", "ca trich", 100000, 200, "image10");

            Food toi_1 = new Food("thit", "ga", 50000, 1000, "image11");
            Food toi_2 = new Food("com", "com_trang", 1000, 100, "image12");
            Food toi_3 = new Food("canh", "canh nuoc", 2500, 400, "image13");
            Food toi_4 = new Food("rau_cu", "com_trang", 7000, 250, "image12");
            Food toi_5 = new Food("ca", "canh nuoc", 40000, 300, "image13");

            dictionary_sang.Add(1, sang_1);
            dictionary_sang.Add(2, sang_2);
            dictionary_sang.Add(3, sang_3);
            dictionary_sang.Add(4, sang_4);
            dictionary_sang.Add(5, sang_5);

            dictionary_trua.Add(6, trua_1);
            dictionary_trua.Add(7, trua_2);
            dictionary_trua.Add(8, trua_3);
            dictionary_trua.Add(9, trua_4);
            dictionary_trua.Add(10, trua_5);

            dictionary_toi.Add(11, toi_1);
            dictionary_toi.Add(12, toi_2);
            dictionary_toi.Add(13, toi_3);
            dictionary_toi.Add(14, toi_4);
            dictionary_toi.Add(15, toi_5);
        }
        public DataBase(DataBase data)
        {
                  
        }
        public DataBase(List<Food> food)
        {

        }

        public delegate object TruyVanHandel(params object[] thamso);
        public event TruyVanHandel truyVanEvent;

        private delegate void myDelegate(Dictionary<int,Food> diction);
        public delegate void DelegateIn(Dictionary<int, Food> diction);

        protected string moKetNoi()
        {
            return "mo ket noi\n";
        }
        protected string dongKetNoi()
        {
            return "dong ket noi\n";
        }

        private void inList(Dictionary<int,Food> diction)
        {
            foreach (KeyValuePair<int, Food> dictionary in diction)
            {
                Console.WriteLine(dictionary.Key + "  " + dictionary.Value.tenMonAn + "  " + dictionary.Value.loaiMonAn
                    + "  " + dictionary.Value.kalo + "  " + dictionary.Value.image + "  " + dictionary.Value.giaTien);
            }
        }
        private void In(DelegateIn inList, Dictionary<int, Food> diction)
        {
            inList(diction);
        }
        private void inRaManHinhList(myDelegate inList,int sang,int trua,int toi)
        {
            DataBase data = new DataBase();
            if(sang == 1)
               inList(data.dictionary_sang);
            if (trua == 1)
                inList(data.dictionary_trua);
            if (toi == 1)
                inList(data.dictionary_toi);
        }
        public string truyVanMonAn(int sang,int trua,int toi)
        {
            Console.WriteLine(moKetNoi());
            inRaManHinhList(inList,sang,trua,toi);
            Console.WriteLine(dongKetNoi());
            return "chon xong roi\n";
        }
    }
}
