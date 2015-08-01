using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{
    delegate void Played(object sender, string weapon);

    interface IPlayer
    {
        void Play();
        event Played Played;
        string CurrentWeapon { get; }
    }
}
