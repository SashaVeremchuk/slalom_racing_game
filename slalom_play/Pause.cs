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
    public partial class Pause : Form
    {
        Game game;
        Play play;
        public Pause(Game g, Play p, string n)
        {
            InitializeComponent();
            game = g;
            play = p;
        }

        private void vmenu_Click(object sender, EventArgs e)
        {
            Hide();
            game.Updaterec(game.name, play.score );
            game.Show();
            this.Close();
        }

        private void cont_Click(object sender, EventArgs e)
        {
            Hide();
            play.AfterPaus();
            play.Show();
            this.Close();
        }
    }
}
