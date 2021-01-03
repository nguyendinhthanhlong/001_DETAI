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
            foreach(KeyValuePair<int,Food> name in data.dictionary_sang)
            {
                Console.WriteLine(name.Key + "  " + name.Value.tenMonAn);
            }
          
        }
    }
}