namespace kurs
{
    partial class Pause
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
            this.vmenu = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(297, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пауза";
            // 
            // vmenu
            // 
            this.vmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vmenu.AutoSize = true;
            this.vmenu.BackColor = System.Drawing.Color.IndianRed;
            this.vmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.vmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.vmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vmenu.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.vmenu.ForeColor = System.Drawing.Color.White;
            this.vmenu.Location = new System.Drawing.Point(214, 399);
            this.vmenu.Margin = new System.Windows.Forms.Padding(0);
            this.vmenu.Name = "vmenu";
            this.vmenu.Size = new System.Drawing.Size(340, 54);
            this.vmenu.TabIndex = 12;
            this.vmenu.Text = "Меню";
            this.vmenu.UseVisualStyleBackColor = false;
            this.vmenu.Click += new System.EventHandler(this.vmenu_Click);
            // 
            // cont
            // 
            this.cont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cont.AutoSize = true;
            this.cont.BackColor = System.Drawing.Color.IndianRed;
            this.cont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cont.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.cont.ForeColor = System.Drawing.Color.White;
            this.cont.Location = new System.Drawing.Point(214, 304);
            this.cont.Margin = new System.Windows.Forms.Padding(0);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(340, 54);
            this.cont.TabIndex = 11;
            this.cont.Text = "Продолжить";
            this.cont.UseVisualStyleBackColor = false;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kurs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 853);
            this.Controls.Add(this.vmenu);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.label1);
            this.Name = "Pause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vmenu;
        private System.Windows.Forms.Button cont;
    }
}