using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{
    class Human : IPlayer
    {
        public event Played Played;
        private Boolean humanTurn = false;

        public string CurrentWeapon { get; private set; }

        public void Play() {

            humanTurn = true;

        }

        public void UserInput(string weapon) {
        

            if (humanTurn)
            {
                this.CurrentWeapon = weapon;

                if (Played != null) {
                    Played(this, weapon);
                }
            }
        }

    }
}
