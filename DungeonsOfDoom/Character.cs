using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Character : RoomContent
    {
        //int Health;
        //int Damage;

        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
    }
}
