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
    public partial class Name : Form
    {
        string pname="";
        public Name()
        {
            InitializeComponent();
        }
        private void begin_Click(object sender, EventArgs e)
        {
            pname = Player_name.Text.Trim();
            if (pname == "" || pname==null)
                return;
            else
            {
                Game mygame = new Game(pname);
                Hide();
                mygame.Show();
                this.Close();
            }
        }
    }
}
