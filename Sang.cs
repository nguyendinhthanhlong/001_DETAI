﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DETAI
{
    public class Sang
    {
       public Dictionary<int,Food> ListMonAn= new Dictionary<int,Food>();
       public int flag { get; set; }
        public Sang()
        {
            flag = 0;
        }
    }
}