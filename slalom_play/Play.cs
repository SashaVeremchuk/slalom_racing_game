using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace kurs
{
    public partial class Play : Form
    {
        bool goLeft, goRight;
        public int score;
        Game game;
        int time = 60;//таймер
        Random rnd = new Random();
        int gift_sp;

        public Play(Game g, string n)
        {
            InitializeComponent();
            resetGame();
            game = g;
        }
        private void gameOver()
        {
            Hide();
            gameTimer.Stop();
            Gameover g = new Gameover(game, game.name, score);
            g.Show();
            time = 60;// установка изначального значения таймера
        }
        private void resetGame()// начинает игру
        {
            playerL.Top = 5;
            gift_sp = 8;
            gameTimer.Start();
            score = 0;
            textBox1.Text = score.ToString();
            timer1.Enabled = true;

            gift.Left = rnd.Next(20, 100);
            gift2.Left = rnd.Next(100, 180);
            gift3.Left = rnd.Next(180, 260);
            gift4.Left = rnd.Next(260, 340);
            gift5.Left = rnd.Next(340, 420);
            gift6.Left = rnd.Next(420, 500);

            grinch.Left = rnd.Next(20, 500);
            grinch.Top = rnd.Next(900, 1700);


            gold.Left = rnd.Next(20, 500);

            gold.Top = rnd.Next(900, 1700);

            gift.Top = rnd.Next(900, 1700);
            gift2.Top = rnd.Next(900, 1700);
            gift3.Top = rnd.Next(900, 1700);
            gift4.Top = rnd.Next(900, 1700);
            gift5.Top = rnd.Next(900, 1700);
            gift6.Top = rnd.Next(900, 1700);
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                goLeft = true;
            if (e.KeyCode == Keys.D)
                goRight = true;
        }


        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                goLeft = false;
            if (e.KeyCode == Keys.D)
                goRight = false;
        }

        public void AfterPaus()
        {
            gameTimer.Start();
            timer1.Enabled = true;
        }
        
        public void Collision(PictureBox pictureBox, PictureBox player, int n)
        {
            if (player.Bounds.IntersectsWith(pictureBox.Bounds))
            {
                pictureBox.Top = 1200;
                if(n == 1)
                {
                    score += 1;
                    gift.Left = rnd.Next(20, 100);
                }
                if(n ==  2)
                {
                    score += 1;
                    gift2.Left = rnd.Next(100, 180);
                }
                if (n == 3)
                {
                    score += 1;
                    gift3.Left = rnd.Next(180, 260);
                }
                if(n == 4)
                {
                    score += 1;
                    gift4.Left = rnd.Next(260, 340);
                }
                if(n == 5)
                {
                    score += 1;
                    gift5.Left = rnd.Next(340, 420);
                }
                if (n == 6)
                {
                    score += 1;
                    gift6.Left = rnd.Next(420, 500);
                }
                if (n == 7)
                {
                    score += 5;
                    gold.Left = rnd.Next(20, 500);
                    gift_sp += 1;
                }

                if(n == 8)
                {
                    score -= 10;
                    grinch.Left = rnd.Next(20, 500);
                }

            }
        }
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            textBox1.Text = score.ToString();

            if(playerL.Top < 305)
                playerL.Top += 4;
            

            if(playerL.Top >= 305 && time > 2)
                playerL.Top = 305;

            if(time <= 2 )
                playerL.Top += 4;

            if (playerL.Top >= 620)
                gameOver();


            if (goLeft == true && playerL.Left > 0)
                playerL.Left -= 12;

            if (goRight == true && playerL.Left < 870)
                playerL.Left += 12;

            gift.Top -= gift_sp;
            gift2.Top -= gift_sp;
            gift3.Top -= gift_sp;
            gift4.Top -= gift_sp;
            gift5.Top -= gift_sp;
            gift6.Top -= gift_sp;
            gold.Top -= gift_sp;

            if(score > 90)
                grinch.Top -= gift_sp;         

            Collision(gift, playerL, 1);
            Collision(gift2, playerL, 2);
            Collision(gift3, playerL, 3);
            Collision(gift4, playerL, 4);
            Collision(gift5, playerL, 5);
            Collision(gift6, playerL, 6);

            Collision(gold, playerL, 7);

            Collision(grinch, playerL, 8);

            if (gift.Top < -80)
            {
                gift.Top = 1200;
                gift.Left = rnd.Next(20, 100);
            }
            if (gift2.Top < -80)
            {
                gift2.Top = 1200;
                gift2.Left = rnd.Next(100, 180);
            }
            if (gift3.Top < -80)
            {
                gift3.Top = 1200;
                gift3.Left = rnd.Next(180, 260);
            }
            if (gift4.Top < -80)
            {
                gift4.Top = 1200;
                gift4.Left = rnd.Next(260, 340);
            }
            if (gift5.Top < -80)
            {
                gift5.Top = 1200;
                gift5.Left = rnd.Next(340, 420);
            }
            if (gift6.Top < -80)
            {
                gift6.Top = 1200;
                gift6.Left = rnd.Next(420, 500);
            }
            if (gold.Top < -80)
            {
                gold.Top = 1200;
                gold.Left = rnd.Next(20, 500);
            }

            if (grinch.Top < -80)
            {
                grinch.Top = 1200;
                grinch.Left = rnd.Next(20, 500);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//таймер по минуте
        {
            time--;
            label1.Text = time.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            Hide();
            Pause n = new Pause(game, this, game.name);
            n.Show();
            timer1.Enabled = false;// таймер стоп
        }
    }
}
