using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace kurs
{
    public partial class Record : Form
    {
        Game game;
        public Record(Game g)
        {
            InitializeComponent();
            game = g;
        }

        private void rec_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\User\Desktop\Курсовая\my_kurs\records.txt";

            using (FileStream stream = File.OpenRead(path))
            {
                int totalBytes = (int)stream.Length;
                byte[] bytes = new byte[totalBytes];
                int bytesRead = 0;

                while (bytesRead < totalBytes)
                {
                    int len = stream.Read(bytes, bytesRead, totalBytes);
                    bytesRead += len;
                }

                string text = Encoding.UTF8.GetString(bytes);
                textBox1.Text = text;
                rec.Enabled = false;
            }
            
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\Курсовая\my_kurs\records.txt", string.Empty);
            Clean.Enabled = false;
            textBox1.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            game.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
    }
}
