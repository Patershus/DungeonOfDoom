﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player(int health, int x, int y, int damage) : base(health, damage, 'P')
        {
            X = x;
            Y = y;
        }

        //public int Health { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
