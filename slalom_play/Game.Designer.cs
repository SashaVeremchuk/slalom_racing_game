namespace kurs
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.beginGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rule = new System.Windows.Forms.Button();
            this.Change_player = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginGame
            // 
            this.beginGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.beginGame.AutoSize = true;
            this.beginGame.BackColor = System.Drawing.Color.IndianRed;
            this.beginGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.beginGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.beginGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginGame.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginGame.ForeColor = System.Drawing.Color.White;
            this.beginGame.Location = new System.Drawing.Point(219, 165);
            this.beginGame.Margin = new System.Windows.Forms.Padding(0);
            this.beginGame.Name = "beginGame";
            this.beginGame.Size = new System.Drawing.Size(347, 54);
            this.beginGame.TabIndex = 5;
            this.beginGame.Text = "Начать";
            this.beginGame.UseVisualStyleBackColor = false;
            this.beginGame.Click += new System.EventHandler(this.beginGame_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(210, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите пункт меню";
            // 
            // Rule
            // 
            this.Rule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rule.AutoSize = true;
            this.Rule.BackColor = System.Drawing.Color.IndianRed;
            this.Rule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Rule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Rule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rule.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rule.ForeColor = System.Drawing.Color.White;
            this.Rule.Location = new System.Drawing.Point(219, 244);
            this.Rule.Margin = new System.Windows.Forms.Padding(0);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(347, 54);
            this.Rule.TabIndex = 6;
            this.Rule.Text = "Правила";
            this.Rule.UseVisualStyleBackColor = false;
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // Change_player
            // 
            this.Change_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Change_player.AutoSize = true;
            this.Change_player.BackColor = System.Drawing.Color.IndianRed;
            this.Change_player.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Change_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Change_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_player.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_player.ForeColor = System.Drawing.Color.White;
            this.Change_player.Location = new System.Drawing.Point(219, 322);
            this.Change_player.Margin = new System.Windows.Forms.Padding(0);
            this.Change_player.Name = "Change_player";
            this.Change_player.Size = new System.Drawing.Size(347, 54);
            this.Change_player.TabIndex = 7;
            this.Change_player.Text = "Сменить игрока";
            this.Change_player.UseVisualStyleBackColor = false;
            this.Change_player.Click += new System.EventHandler(this.Change_player_Click);
            // 
            // Records
            // 
            this.Records.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Records.AutoSize = true;
            this.Records.BackColor = System.Drawing.Color.IndianRed;
            this.Records.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Records.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Records.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records.ForeColor = System.Drawing.Color.White;
            this.Records.Location = new System.Drawing.Point(219, 404);
            this.Records.Margin = new System.Windows.Forms.Padding(0);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(347, 54);
            this.Records.TabIndex = 8;
            this.Records.Text = "Посмотреть рекорды";
            this.Records.UseVisualStyleBackColor = false;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // Out
            // 
            this.Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Out.AutoSize = true;
            this.Out.BackColor = System.Drawing.Color.IndianRed;
            this.Out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Out.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Out.ForeColor = System.Drawing.Color.White;
            this.Out.Location = new System.Drawing.Point(219, 479);
            this.Out.Margin = new System.Windows.Forms.Padding(0);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(347, 54);
            this.Out.TabIndex = 9;
            this.Out.Text = "Выйти из игры";
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kurs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 900);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Change_player);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.beginGame);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посмотреть правила";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion

        private System.Windows.Forms.Button beginGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rule;
        private System.Windows.Forms.Button Change_player;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button Out;
    }
}