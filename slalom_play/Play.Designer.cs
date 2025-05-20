using System.Windows.Forms;
using System;

namespace kurs
{
    partial class Play
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.back = new System.Windows.Forms.Button();
            this.playerL = new System.Windows.Forms.PictureBox();
            this.gift = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gold = new System.Windows.Forms.PictureBox();
            this.gift2 = new System.Windows.Forms.PictureBox();
            this.gift3 = new System.Windows.Forms.PictureBox();
            this.gift4 = new System.Windows.Forms.PictureBox();
            this.gift5 = new System.Windows.Forms.PictureBox();
            this.gift6 = new System.Windows.Forms.PictureBox();
            this.grinch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grinch)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 3;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(593, 105);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(176, 54);
            this.back.TabIndex = 12;
            this.back.Text = "Пауза";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // playerL
            // 
            this.playerL.BackColor = System.Drawing.Color.Transparent;
            this.playerL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerL.Image = global::kurs.Properties.Resources.player;
            this.playerL.Location = new System.Drawing.Point(340, 0);
            this.playerL.Name = "playerL";
            this.playerL.Size = new System.Drawing.Size(95, 83);
            this.playerL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerL.TabIndex = 14;
            this.playerL.TabStop = false;
            // 
            // gift
            // 
            this.gift.BackColor = System.Drawing.Color.Transparent;
            this.gift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift.Image = global::kurs.Properties.Resources.gif;
            this.gift.Location = new System.Drawing.Point(115, 82);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(63, 65);
            this.gift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift.TabIndex = 16;
            this.gift.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 18;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(360, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 54);
            this.textBox1.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(641, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "60";
            // 
            // gold
            // 
            this.gold.BackColor = System.Drawing.Color.Transparent;
            this.gold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gold.Image = ((System.Drawing.Image)(resources.GetObject("gold.Image")));
            this.gold.Location = new System.Drawing.Point(105, 271);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(89, 91);
            this.gold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gold.TabIndex = 0;
            this.gold.TabStop = false;
            // 
            // gift2
            // 
            this.gift2.BackColor = System.Drawing.Color.Transparent;
            this.gift2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift2.Image = global::kurs.Properties.Resources.gif;
            this.gift2.Location = new System.Drawing.Point(115, 178);
            this.gift2.Name = "gift2";
            this.gift2.Size = new System.Drawing.Size(63, 65);
            this.gift2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift2.TabIndex = 31;
            this.gift2.TabStop = false;
            // 
            // gift3
            // 
            this.gift3.BackColor = System.Drawing.Color.Transparent;
            this.gift3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift3.Image = global::kurs.Properties.Resources.gif;
            this.gift3.Location = new System.Drawing.Point(208, 82);
            this.gift3.Name = "gift3";
            this.gift3.Size = new System.Drawing.Size(63, 65);
            this.gift3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift3.TabIndex = 32;
            this.gift3.TabStop = false;
            // 
            // gift4
            // 
            this.gift4.BackColor = System.Drawing.Color.Transparent;
            this.gift4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift4.Image = global::kurs.Properties.Resources.gif;
            this.gift4.Location = new System.Drawing.Point(208, 178);
            this.gift4.Name = "gift4";
            this.gift4.Size = new System.Drawing.Size(63, 65);
            this.gift4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift4.TabIndex = 33;
            this.gift4.TabStop = false;
            // 
            // gift5
            // 
            this.gift5.BackColor = System.Drawing.Color.Transparent;
            this.gift5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift5.Image = global::kurs.Properties.Resources.gif;
            this.gift5.Location = new System.Drawing.Point(297, 178);
            this.gift5.Name = "gift5";
            this.gift5.Size = new System.Drawing.Size(63, 65);
            this.gift5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift5.TabIndex = 34;
            this.gift5.TabStop = false;
            // 
            // gift6
            // 
            this.gift6.BackColor = System.Drawing.Color.Transparent;
            this.gift6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gift6.Image = global::kurs.Properties.Resources.gif;
            this.gift6.Location = new System.Drawing.Point(297, 82);
            this.gift6.Name = "gift6";
            this.gift6.Size = new System.Drawing.Size(63, 65);
            this.gift6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gift6.TabIndex = 35;
            this.gift6.TabStop = false;
            // 
            // grinch
            // 
            this.grinch.BackColor = System.Drawing.Color.Transparent;
            this.grinch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grinch.Image = ((System.Drawing.Image)(resources.GetObject("grinch.Image")));
            this.grinch.Location = new System.Drawing.Point(231, 283);
            this.grinch.Name = "grinch";
            this.grinch.Size = new System.Drawing.Size(145, 142);
            this.grinch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grinch.TabIndex = 36;
            this.grinch.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 853);
            this.Controls.Add(this.grinch);
            this.Controls.Add(this.gift2);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.playerL);
            this.Controls.Add(this.gift);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gift5);
            this.Controls.Add(this.gift6);
            this.Controls.Add(this.gift4);
            this.Controls.Add(this.gift3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.KeyPreview = true;
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.playerL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grinch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox gift;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.PictureBox playerL;
        private Timer timer1;
        private Label label1;
        private PictureBox gold;
        private PictureBox gift2;
        private PictureBox gift3;
        private PictureBox gift4;
        private PictureBox gift5;
        private PictureBox gift6;
        private PictureBox grinch;
    }
}

