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
    public partial class Rule : Form
    {
        Game game;
        public Rule(Game g)
        {
            InitializeComponent();
            game = g;
        }

        private void begin_Click(object sender, EventArgs e)
        {
            Hide();
            game.Show();
            this.Close();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                