using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{

    class Game
    {
        public delegate void RoundFinishedDelegate(object sender, System.EventArgs e);
        public event RoundFinishedDelegate RoundFinished;

        public int gamesPlayed { get; private set; }
        public int humanWins { get; private set; }
        public int computerWins { get; private set; }

        public Boolean computerWon { get; private set; }
        public Boolean humanWon { get; private set; }
        public Boolean isTie { get; private set; }

        public IPlayer Human { get; private set; }
        public IPlayer Computer{get;private set;}

        public Game(IPlayer human, IPlayer computer) 
        {
            this.Human = human;
            this.Computer = computer;
            this.gamesPlayed = 0;
            this.humanWins = 0;
            this.computerWins = 0;

            this.Human.Played += human_Played;
            this.Computer.Played += computer_Played;

        }

        void computer_Played(object sender, string weapon)
        {
            CheckHasWin();
            Human.Play();
        }

        void human_Played(object sender, string weapon)
        {
            Computer.Play();
        }

        void CheckHasWin()
        {
            isTie = false;
            computerWon = false;
            humanWon = false;

            if (Human.CurrentWeapon == "Rock" && Computer.CurrentWeapon == "Rock")
            {
                isTie = true;             
            }

            if (Human.CurrentWeapon == "Paper" && Computer.CurrentWeapon == "Paper")
            {
                isTie = true;             

            }

            if (Human.CurrentWeapon == "Scissors" && Computer.CurrentWeapon == "Scissors")
            {
                isTie = true;             

            }

            if (Human.CurrentWeapon == "Rock" && Computer.CurrentWeapon == "Paper")
            {
                computerWon = true;
                computerWins++;

            }

            if (Human.CurrentWeapon == "Rock" && Computer.CurrentWeapon == "Scissors")
            {
                humanWon = true;
                humanWins++;

            }

            if (Human.CurrentWeapon == "Paper" && Computer.CurrentWeapon == "Rock")
            {
                humanWon = true;
                humanWins++;

            }

            if (Human.CurrentWeapon == "Paper" && Computer.CurrentWeapon == "Scissors")
            {
                computerWon = true;
                computerWins++;

            }

            if (Human.CurrentWeapon == "Scissors" && Computer.CurrentWeapon == "Rock")
            {
                computerWon = true;
                computerWins++;

            }

            if (Human.CurrentWeapon == "Scissors" && Computer.CurrentWeapon == "Paper")
            {
                humanWon = true;
                humanWins++;

            }

            gamesPlayed++;

            if (RoundFinished != null)
                RoundFinished(this, new EventArgs());

/*          label11.Text = humanWins.ToString();
            label13.Text = computerWins.ToString();
            label10.Text = gamesPlayed.ToString();
 */
 
        }
    }
}
