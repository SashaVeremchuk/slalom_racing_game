using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Gameover : Form
    {
        Game game;
        int score;
        public Gameover(Game g, string n, int s) 
        {
            InitializeComponent();
            game = g;
            game.name = n;
            score = s;
        }

        private void begin_Click(object sender, EventArgs e)
        {
            Hide();
            game.Show();
            game.Updaterec(game.name, score);
            this.Close();
        }
    }
}
