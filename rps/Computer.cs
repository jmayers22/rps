using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{
    class Computer : IPlayer
    {
        string[] weapons = new string[3] { "Rock", "Paper", "Scissors" };

        public event Played Played;

        Random r = new Random();

        public string CurrentWeapon { get; private set; }


        public void Play()
        {
            int randomSelection = r.Next(weapons.Count());
            string randomString = weapons[randomSelection];

            this.CurrentWeapon = randomString;

            if (Played != null) 
            {
                Played(this, randomString);
            }

        }

        
    }
}
