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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void begin_Click(object sender, EventArgs e)
        {
            Hide();
            Name n = new Name();
            n.Show();
        }

        private void label1_Click(object sender, EventArgs e){}
    }
}
