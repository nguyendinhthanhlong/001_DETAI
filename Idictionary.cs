using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public interface IDictionary
    {
        Dictionary<int, Food> dictionary_sang { get; set; }
        Dictionary<int, Food> dictionary_trua { get; set; }
        Dictionary<int, Food> dictionary_toi { get; set; }

    }
}
