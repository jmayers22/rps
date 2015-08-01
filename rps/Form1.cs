using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rps
{
    public partial class Form1 : Form
    {

        Human human = new Human();
        Game game;


        public Form1()
        {
            InitializeComponent();

            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;

            NewGame();

            label10.Text = game.gamesPlayed.ToString();
            label11.Text = game.humanWins.ToString();
            label13.Text = game.computerWins.ToString();


        }
        private void NewGame()
        {
            game = new Game(human, new Computer());
            game.RoundFinished += game_RoundFinished;

            label10.Text = game.gamesPlayed.ToString();
            label11.Text = game.humanWins.ToString();
            label13.Text = game.computerWins.ToString();

            label3.Text = "";
            label2.Text = "";

            label5.Text = "";

            human.Play();
        }

        void game_RoundFinished(object sender, EventArgs e)
        {
            label10.Text = game.gamesPlayed.ToString();
            label11.Text = game.humanWins.ToString();
            label13.Text = game.computerWins.ToString();

            label3.Text = game.Computer.CurrentWeapon;

            if (game.isTie)
                label5.Text = "Tie";
            else if (game.humanWon)
                label5.Text = "Human won";
            else
                label5.Text = "Computer won";
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Athanasios Emmanouilidis and jvbsl.");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();

        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            label3.Text = "";
            human.UserInput(button.Text);
            label2.Text = human.CurrentWeapon;
            // Copy paste them


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



    }
}
