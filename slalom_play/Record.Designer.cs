namespace kurs
{
    partial class Record
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
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.rec = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(307, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Рекорды:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(216, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 328);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rec
            // 
            this.rec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rec.AutoSize = true;
            this.rec.BackColor = System.Drawing.Color.IndianRed;
            this.rec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.rec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rec.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.rec.ForeColor = System.Drawing.Color.White;
            this.rec.Location = new System.Drawing.Point(216, 513);
            this.rec.Margin = new System.Windows.Forms.Padding(0);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(341, 54);
            this.rec.TabIndex = 9;
            this.rec.Text = "Вывести рекорды";
            this.rec.UseVisualStyleBackColor = false;
            this.rec.Click += new System.EventHandler(this.rec_Click);
            // 
            // Clean
            // 
            this.Clean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clean.AutoSize = true;
            this.Clean.BackColor = System.Drawing.Color.IndianRed;
            this.Clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.Clean.ForeColor = System.Drawing.Color.White;
            this.Clean.Location = new System.Drawing.Point(216, 586);
            this.Clean.Margin = new System.Windows.Forms.Padding(0);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(341, 54);
            this.Clean.TabIndex = 10;
            this.Clean.Text = "Очистить рекорды";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.IndianRed;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(216, 659);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(341, 54);
            this.back.TabIndex = 11;
            this.back.Text = "Меню";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kurs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 853);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Button rec;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button back;
    }
}