﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public Potion(int healing) : base("potion")
        {
            Healing = healing;
        }

        public int Healing { get; set; }
    }
}
