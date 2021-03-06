﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Character : MapObject
    {
        //int Health;
        //int Damage;

        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(int health, int damage, char mapChar) : base(mapChar)
        {
            Health = health;
            Damage = damage;
        }
    }
}
