namespace kurs
{
    partial class Name
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.Player_name = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(280, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя:";
            // 
            // begin
            // 
            this.begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.begin.AutoSize = true;
            this.begin.BackColor = System.Drawing.Color.IndianRed;
            this.begin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.begin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.begin.ForeColor = System.Drawing.Color.White;
            this.begin.Location = new System.Drawing.Point(217, 345);
            this.begin.Margin = new System.Windows.Forms.Padding(0);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(337, 83);
            this.begin.TabIndex = 2;
            this.begin.Text = "Продолжить";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // Player_name
            // 
            this.Player_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Player_name.BeepOnError = true;
            this.Player_name.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.Player_name.Location = new System.Drawing.Point(217, 276);
            this.Player_name.Name = "Player_name";
            this.Player_name.Size = new System.Drawing.Size(337, 48);
            this.Player_name.TabIndex = 3;
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kurs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 853);
            this.Controls.Add(this.Player_name);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label1);
            this.Name = "Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.MaskedTextBox Player_name;
    }
}